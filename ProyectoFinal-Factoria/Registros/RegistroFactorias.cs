using System;
using System.Linq;
using System.Windows.Forms;
using Entidades;

namespace ProyectoFinal_Factoria.Registros
{
    public partial class RegistroFactorias : Form
    {
        public RegistroFactorias()
        {
            InitializeComponent();

            ValidarCampos();
            LimpiarCampos();
        }

        private void ValidarCampos()
        {
            var val = new Utileria(IDtextBox, "Ej.: 0001", RNCtextBox, "N");
            var val1 = new Utileria(RNCtextBox, "Ej.: 4789", NombretextBox, "N");
            var val2 = new Utileria(NombretextBox, "Ej.: Juan González", DirecciontextBox, "L");
            var val3 = new Utileria(DirecciontextBox, "Ej.: SFM, Rep. Dom.", TelefonotextBox, "LN");
            var val4 = new Utileria(TelefonotextBox, "Ej.: 8095746213", NombretextBox, "N");

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var factoria = BLL.FactoriasBLL.Buscar(Utileria.ToInt(IDtextBox.Text));
            if(factoria != null)
            {
                CargarCampos(factoria);
            }else
            {
                MessageBox.Show("Esa factoria no existe","-- Aviso --", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LlenarCampos(Factorias factoria)
        {
            string mensaje = "Este campo es obligatorio";
            if(RNCtextBox.Text != string.Empty)
            {
                if(NombretextBox.Text != string.Empty)
                {
                    if(DirecciontextBox.Text != string.Empty)
                    {
                        if(TelefonotextBox.Text != string.Empty)
                        {
                            factoria = new Factorias();
                            factoria.FactoriaRNC = Utileria.ToInt(RNCtextBox.Text);
                            factoria.NombreSucursal = NombretextBox.Text;
                            factoria.Direccion = DirecciontextBox.Text;
                            factoria.Telefono = Utileria.ToInt64(TelefonotextBox.Text);
                            factoria.FactoriaId = Utileria.ToInt(IDtextBox.Text);
                        }
                        else {
                            CampoObligatorioerrorProvider.SetError(TelefonotextBox, mensaje);
                            TelefonotextBox.Focus();
                        }
                    }
                    else {
                        CampoObligatorioerrorProvider.SetError(DirecciontextBox, mensaje);
                        DirecciontextBox.Focus();
                    }
                }
                else {
                    CampoObligatorioerrorProvider.SetError(NombretextBox, mensaje);
                    NombretextBox.Focus();
                }
            }
            else {
                CampoObligatorioerrorProvider.SetError(RNCtextBox, mensaje);
                RNCtextBox.Focus();
            }            
        }

        private void CargarCampos(Factorias factoria)
        {
            RNCtextBox.Text = factoria.FactoriaRNC.ToString();
            NombretextBox.Text = factoria.NombreSucursal;
            DirecciontextBox.Text = factoria.Direccion;
            TelefonotextBox.Text = factoria.Telefono.ToString();
        }

        private void LimpiarCampos()
        {
            int id = BLL.FactoriasBLL.Identity();
            IDtextBox.Clear();
            RNCtextBox.Clear();
            NombretextBox.Clear();
            TelefonotextBox.Clear();
            DirecciontextBox.Clear();
            if (id > 1 || BLL.FactoriasBLL.GetList().Count() > 0)
                IDtextBox.Text = (id + 1).ToString();
            else
                IDtextBox.Text = id.ToString();
            RNCtextBox.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Factorias factoria = null;
            LlenarCampos(factoria);
            if(factoria != null)
            {
                if (BLL.FactoriasBLL.Insertar(factoria))
                {
                    MessageBox.Show("Ha registrado una nueva 'Factoria'", "-- Transacción Exitosa --", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("No se pudo registrar", "-- Transacción Fallida --", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimpiarCampos();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(IDtextBox.Text))
            {
                var factoria = BLL.FactoriasBLL.Buscar(Utileria.ToInt(IDtextBox.Text));
                if(factoria != null)
                {
                    if (BLL.FactoriasBLL.Eliminar(factoria))
                        MessageBox.Show("La factoria ha sido eliminada", "-- Transacción Exitosa --", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("No se pudo eliminar", "-- Transacción Fallida --", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Factoria no encontrada", "-- Consulta Fallida --", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("No puedes dejar este campo vacio", "-- Aviso --", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IDtextBox.Focus();
            }
            LimpiarCampos();
        }

        private void RegistroFactorias_Load(object sender, EventArgs e)
        {

        }
    }
}
