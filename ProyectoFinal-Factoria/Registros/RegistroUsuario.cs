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
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
            TipoComboBox.DataSource = BLL.TiposDeUsuariosBLL.GetList();
            TipoComboBox.DisplayMember = "Nombre";
            TipoComboBox.ValueMember = "TipoUsuarioId";
            var val = new Utileria(IdTextBox, "Ej.: 01", UsuarioTextBox, "N");
            var val1 = new Utileria(UsuarioTextBox, "Ej.: Juan Pérez", ContraseñaTextBox, "LN");
            var val2 = new Utileria(ContraseñaTextBox, "Contraseña", ConfirmarTextBox, "LN");
            var val3 = new Utileria(ConfirmarTextBox, "Contraseña", IdTextBox, "LN");
        }

        private void CleanCampos()
        {
            IdTextBox.Text = "Ej.: 01";
            UsuarioTextBox.Text = "Ej.: Juan Pérez";
            ContraseñaTextBox.Text = ConfirmarTextBox.Text = "Contraseña";
            IdTextBox.ForeColor = UsuarioTextBox.ForeColor = ContraseñaTextBox.ForeColor = ConfirmarTextBox.ForeColor = Color.Silver;
            IdTextBox.Focus();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int Id;
            int.TryParse(IdTextBox.Text, out Id);
            var User = BLL.UsuariosBLL.Buscar(Id);
            if(User != null)
            {
                UsuarioTextBox.Text = User.Nombre;
                ContraseñaTextBox.Text = ConfirmarTextBox.Text = User.Contraseña;
            }else
            {
                MessageBox.Show("No se encontró ningun Usuario con Id = " + Id, "-- Consulta Fallida --", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CleanCampos();
            }
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            int Id;
            int.TryParse(IdTextBox.Text, out Id);
            BLL.UsuariosBLL.Insertar(new Usuarios(Id, UsuarioTextBox.Text, ContraseñaTextBox.Text, (int)TipoComboBox.SelectedValue));
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            CleanCampos();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int Id;
            int.TryParse(IdTextBox.Text, out Id);
            BLL.UsuariosBLL.Eliminar(BLL.UsuariosBLL.Buscar(Id));
        }
    }
}
