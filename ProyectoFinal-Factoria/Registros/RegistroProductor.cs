using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFinal_Factoria.Registros
{
    public partial class RegistroProductor : Form
    {
        List<Fincas> lista = null;

        int fila = -1;

        public RegistroProductor()
        {
            InitializeComponent();

            CargarFactorias();
            Validaciones();
            LimpiarCampos();
        }

        private void Validaciones()
        {
            var val = new Utileria(ProductorIdTextBox, "Ejemplo: 0001", NombresTextBox, "N");
            var val1 = new Utileria(NombresTextBox, "Ejemplo: Juan Pérez", CedulaMaskedTextBox, "L");
            var val2 = new Utileria(AsociaciontextBox, "Ejemplo: Los Organicos", NumeroParcelatextBox, "LN");
            var val3 = new Utileria(NumeroParcelatextBox, "Ejemplo: 2145", SectortextBox, "N");
            var val4 = new Utileria(SectortextBox, "Ejemplo: 2145", PropietariotextBox, "LN");
            var val5 = new Utileria(PropietariotextBox, "Ejemplo: 2145", NumeroParcelatextBox, "L");
        }

        private void CargarFactorias()
        {
            var lista = BLL.FactoriasBLL.GetList();
            if (lista.Count() <= 0)
            {
                var fact = new Factorias(354684, "Tenares", "La Zursa, #3 Sto. Dgo.", 8095878767);
                BLL.FactoriasBLL.Insertar(fact);
                lista = BLL.FactoriasBLL.GetList();
            }

            FactoriaComboBox.DataSource = lista;
            FactoriaComboBox.ValueMember = "FactoriaRNC";
            FactoriaComboBox.DisplayMember = "NombreSucursal";
        }

        private Int64 ToInt64(string texto)
        {
            Int64 numero;
            Int64.TryParse(texto, out numero);
            return numero;
        }

        private int ToInt(string texto)
        {
            int numero;
            int.TryParse(texto, out numero);
            return numero;
        }

        private void LimpiarCampos()
        {
            lista = new List<Fincas>();
            FincasdataGridView.DataSource = null;
            int id = BLL.ProductoresBLL.Identity();
            ProductorIdTextBox.Clear();
            NombresTextBox.Clear();
            CedulaMaskedTextBox.Clear();
            NumeroParcelatextBox.Clear();
            SectortextBox.Clear();
            AsociaciontextBox.Clear();
            PropietariotextBox.Clear();
            if (id > 1 || BLL.ProductoresBLL.GetList().Count > 0)
                ProductorIdTextBox.Text = (id + 1).ToString();
            else
                ProductorIdTextBox.Text = id.ToString();
            NombresTextBox.Focus();
        }

        public Productores CrearProductor()
        {
            Productores productor = null;
            string mensaje = "Este campo es obligatorio";
            if(ProductorIdTextBox.Text != string.Empty)
            {
                if (NombresTextBox.Text != string.Empty)
                {
                    if (CedulaMaskedTextBox.MaskFull)
                    {
                        productor = new Productores();
                        productor.ProductorId = ToInt(ProductorIdTextBox.Text);
                        var cedula = CedulaMaskedTextBox.Text.Split('-');
                        string Ced = cedula[0] + cedula[1] + cedula[2];
                        productor.FactoriaRNC = (int)FactoriaComboBox.SelectedValue;
                        productor.Nombres = NombresTextBox.Text;
                        productor.Asociacion = AsociaciontextBox.Text;
                        productor.Cedula = ToInt64(Ced);
                    }
                    else
                    {
                        CampoObligatorioerrorProvider.SetError(CedulaMaskedTextBox, mensaje);
                        CedulaMaskedTextBox.Clear();
                        CedulaMaskedTextBox.Focus();
                    }
                }
                else
                {
                    CampoObligatorioerrorProvider.SetError(NombresTextBox, mensaje);
                    NombresTextBox.Focus();
                }
            }
            else {
                CampoObligatorioerrorProvider.SetError(ProductorIdTextBox, mensaje);
                ProductorIdTextBox.Focus();
            }
            

            return productor;
        }

        public void VerificarProductorId()
        {
            int id = BLL.ProductoresBLL.Identity();
            foreach (var finca in lista)
            {
                finca.ProductorId = id;
            }
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Productores productor = CrearProductor();
            if (productor != null)
            {
                if (BLL.ProductoresBLL.Insertar(productor))
                {
                    VerificarProductorId();
                    if (BLL.FincasBLL.Insertar(lista))
                        MessageBox.Show("Ha Registrado Un Productor", "-- Transacción Exitosa --", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("No se pudo realizar la operacion solicitada", "-- Transacción Fallida --", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimpiarCampos();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ProductorIdTextBox.Text))
            {
                var productor = BLL.ProductoresBLL.Buscar(ToInt(ProductorIdTextBox.Text));
                lista = BLL.FincasBLL.GetList(ToInt(ProductorIdTextBox.Text));
                if (productor != null)
                {
                    NombresTextBox.Text = productor.Nombres;
                    CedulaMaskedTextBox.Text = productor.Cedula.ToString();
                    FincasdataGridView.DataSource = null;
                    FincasdataGridView.DataSource = lista;
                    AsociaciontextBox.Text = productor.Asociacion;
                }
                else
                {
                    MessageBox.Show("No Se Encontro El Productor Solicitado", "-- Consulta Fallida --", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ProductorIdTextBox.Clear();
                    ProductorIdTextBox.Focus();
                }
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            var productor = BLL.ProductoresBLL.Buscar(ToInt(ProductorIdTextBox.Text));
            if (fila >= 0 && productor != null)
            {
                BLL.FincasBLL.Eliminar(BLL.FincasBLL.Buscar(lista.ElementAt(fila).FincaId));
                fila = -1;
                lista = BLL.FincasBLL.GetList(ToInt(ProductorIdTextBox.Text));
                FincasdataGridView.DataSource = null;
                FincasdataGridView.DataSource = lista;
            }
            else
            {
                if (productor != null)
                {
                    if (BLL.FincasBLL.Eliminar(productor.ProductorId))
                        if (BLL.ProductoresBLL.Eliminar(productor))
                        {
                            MessageBox.Show("Productor Eliminado", "-- Transacción Exitosa --", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido eliminar", "-- Transacción Fallida --", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
            }
            LimpiarCampos();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NumeroParcelatextBox.Text))
            {
                if (!string.IsNullOrEmpty(SectortextBox.Text))
                {
                    var finca = new Fincas(ToInt(ProductorIdTextBox.Text), ToInt(NumeroParcelatextBox.Text), SectortextBox.Text, NombresTextBox.Text);
                    if (!string.IsNullOrEmpty(PropietariotextBox.Text))
                        finca.Propietario = PropietariotextBox.Text;
                    lista.Add(finca);
                    FincasdataGridView.DataSource = null;
                    FincasdataGridView.DataSource = lista;
                }
                else
                {

                }
            }
            else
            {

            }
        }

        private void FincasdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
        }
    }
}
