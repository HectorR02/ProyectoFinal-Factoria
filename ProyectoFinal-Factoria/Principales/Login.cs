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

namespace ProyectoFinal_Factoria.Principales
{
    public partial class Login : Form
    {
        private int intentos;
        public Login()
        {
            InitializeComponent();
            CrearUsuarioAdmin();
            intentos = 0;
        }

        private void IniciarSesionbutton_Click(object sender, EventArgs e)
        {
            Usuarios user = null;
            if (!string.IsNullOrEmpty(nombreTextBox.Text))
            {
                if (!string.IsNullOrEmpty(contraseñaTextBox.Text))
                {
                    user = BLL.UsuariosBLL.Buscar(nombreTextBox.Text, contraseñaTextBox.Text);
                    if (user != null)
                    {
                        var principal = new PantallaPrincipal(user, this);
                        this.Hide();
                        principal.Show();
                    }else
                    {
                        if(intentos < 5)
                        {
                            MessageBox.Show("Ha ocurrido un erro al verificar sus datos de Usuario,\n" +
                            "por favor vuelva ha introducir sus datos de Usuario", "-- Autenticación Fallida --", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            nombreTextBox.Clear();
                            contraseñaTextBox.Clear();
                            nombreTextBox.Focus();
                            ++intentos;
                        }
                        else
                        {
                            MessageBox.Show("Ha sobrepasado el límite de intentos fallidos,\n...Adios.");
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No puedes dejar campos vacios", "-- Aviso --", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    contraseñaTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("No puedes dejar campos vacios", "-- Aviso --", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nombreTextBox.Focus();
            }
        }

        private void CrearUsuarioAdmin()
        {
            if(BLL.UsuariosBLL.GetList().Count() <= 0)
            {
                BLL.UsuariosBLL.Insertar(new Usuarios(1, "Admin", "1234", 1, 6, "Admin"));
            }
        }
    }
}
