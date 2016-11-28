using System;
using System.Windows.Forms;

namespace ProyectoFinal_Factoria.Registros
{
    public partial class RegistroTipoUsuario : Form
    {
        public RegistroTipoUsuario()
        {
            InitializeComponent();

            ValidarCampos();
            LimpiarCampos();
        }

        private void ValidarCampos()
        {
            var val = new Utileria(tipoUsuarioIdTextBox, "Ej.: 0001", nombreTextBox, "N");
            var val1 = new Utileria(nombreTextBox, "Ej.: Juan Isidro", tipoUsuarioIdTextBox, "L");
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int Id;
            int.TryParse(tipoUsuarioIdTextBox.Text, out Id);
            var user = BLL.TiposDeUsuariosBLL.Buscar(Id);
            if (user != null)
                nombreTextBox.Text = user.Nombre;
            else
                MessageBox.Show("El Tipo de Usuario solicitado no existe", "-- Consulta Fallida --", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            var user = BLL.TiposDeUsuariosBLL.Buscar(Utileria.ToInt(tipoUsuarioIdTextBox.Text));
            if (user != null)
                if (BLL.TiposDeUsuariosBLL.Eliminar(user))
                    MessageBox.Show("Registro Eliminado", "-- Transacción Exitosa --", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Ha ocurrido un error", "-- Transacción Fallida --", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("El registro al que ha intentado acceder\nno existe...", "-- AVISO --", MessageBoxButtons.OK, MessageBoxIcon.Error);
            LimpiarCampos();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            string mensaje = "Este campo es obligatorio";

            if (tipoUsuarioIdTextBox.Text != string.Empty)
                if (nombreTextBox.Text != string.Empty)
                    BLL.TiposDeUsuariosBLL.Insertar(new Entidades.TiposDeUsuarios(nombreTextBox.Text));
                else
                {
                    CampoObligatorioerrorProvider.SetError(nombreTextBox, mensaje);
                    nombreTextBox.Focus();
                }
            else
            {
                CampoObligatorioerrorProvider.SetError(tipoUsuarioIdTextBox, mensaje);
                tipoUsuarioIdTextBox.Focus();
            }

            LimpiarCampos();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            int id = BLL.TiposDeUsuariosBLL.Identity();
            tipoUsuarioIdTextBox.Clear();
            nombreTextBox.Clear();
            if (id > 1 || BLL.TiposDeUsuariosBLL.GetList().Count > 0)
                tipoUsuarioIdTextBox.Text = (id + 1).ToString();
            else
                tipoUsuarioIdTextBox.Text = id.ToString();
            nombreTextBox.Focus();
        }
    }
}