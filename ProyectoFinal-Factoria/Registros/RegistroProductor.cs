using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Factoria.Registros
{
    public partial class RegistroProductor : Form
    {
        public RegistroProductor()
        {
            InitializeComponent();
            var val = new Utileria(ProductorIdTextBox, "Ejemplo: 0001", NombresTextBox, "N");
            var val1 = new Utileria(NombresTextBox, "Ejemplo: Juan Pérez", CedulaMaskedTextBox, "L");
            CargarFactorias();
        }

        private void CargarFactorias()
        {
            var fact = new Factorias(354684, "Tenares", "La Zursa, #3 Sto. Dgo.", 8095878767);

            BLL.FactoriasBLL.Insertar(fact);

            FactoriaComboBox.DataSource = BLL.FactoriasBLL.GetList();
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
            ProductorIdTextBox.Clear();
            NombresTextBox.Clear();
            CedulaMaskedTextBox.Clear();
        }

        public Productores CrearProductor()
        {
            Productores productor = null;

            if (!string.IsNullOrEmpty(NombresTextBox.Text))
            {
                if (CedulaMaskedTextBox.MaskFull)
                {
                    var cedula = CedulaMaskedTextBox.Text.Split('-');
                    string Ced = cedula[0] + cedula[1] + cedula[2];
                    productor.FactoriaRNC = (int)FactoriaComboBox.SelectedValue;
                    productor.Nombres = NombresTextBox.Text;
                    productor.Cedula = ToInt64(Ced);
                }
                else
                {
                    CedulaMaskedTextBox.Focus();
                }
            }
            else
            {
                NombresTextBox.Focus();
            }

            return productor;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Productores productor = CrearProductor();
            if (productor != null)
            {
                if (BLL.ProductoresBLL.Insertar(productor))
                    MessageBox.Show("Ha Registrado Un Productor", "-- Transacción Exitosa --", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo realizar la operacion solicitada", "-- Transacción Fallida --", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                if (productor != null)
                {
                    NombresTextBox.Text = productor.Nombres;
                    CedulaMaskedTextBox.Text = productor.Cedula.ToString();
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
            if(productor != null)
            {
                if (BLL.ProductoresBLL.Eliminar(productor))
                {
                    MessageBox.Show("Productor Eliminado", "-- Transacción Exitosa --", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha podido eliminar", "-- Transacción Fallida --", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
