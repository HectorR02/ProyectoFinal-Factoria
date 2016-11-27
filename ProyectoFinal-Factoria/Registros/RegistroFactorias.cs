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

            LimpiarCampos();
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
            if(!string.IsNullOrEmpty(RNCtextBox.Text))
            {
                if(!string.IsNullOrEmpty(NombretextBox.Text))
                {
                    if(!string.IsNullOrEmpty(DirecciontextBox.Text))
                    {
                        if(!string.IsNullOrEmpty(TelefonotextBox.Text))
                        {
                            factoria.FactoriaRNC = Utileria.ToInt(RNCtextBox.Text);
                            factoria.NombreSucursal = NombretextBox.Text;
                            factoria.Direccion = DirecciontextBox.Text;
                            factoria.Telefono = Utileria.ToInt64(TelefonotextBox.Text);
                            factoria.FactoriaId = Utileria.ToInt(IDtextBox.Text);
                        }
                        else { }
                    }
                    else { }
                }
                else { }
            }
            else { }            
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
            var factoria = new Factorias();
            LlenarCampos(factoria);
            if (BLL.FactoriasBLL.Insertar(factoria))
            {
                MessageBox.Show("Ha registrado una nueva 'Factoria'", "-- Transacción Exitosa --", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo registrar", "-- Transacción Fallida --", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void RegistroFactorias_Load(object sender, EventArgs e)
        {

        }
    }
}
