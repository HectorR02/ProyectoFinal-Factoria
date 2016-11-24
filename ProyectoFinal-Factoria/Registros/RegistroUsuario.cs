using Entidades;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinal_Factoria.Registros
{
    public partial class RegistroUsuario : Form
    {

        public RegistroUsuario()
        {
            InitializeComponent();
            ValidarCampos();
            CleanCampos();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var User = BLL.UsuariosBLL.Buscar(Utileria.ToInt(IdTextBox.Text));
            if (User != null)
            {
                UsuarioTextBox.Text = User.Nombre;
                ContraseñaTextBox.Text = ConfirmarTextBox.Text = User.Contraseña;
                TipoComboBox.SelectedValue = User.TipoUsuarioId;
                MostrarPermisos(User);
            }
            else
            {
                MessageBox.Show("No se encontró ningun Usuario con Id = " + Utileria.ToInt(IdTextBox.Text), "-- Consulta Fallida --", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CleanCampos();
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            CleanCampos();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = null;
            if (!string.IsNullOrEmpty(UsuarioTextBox.Text))
            {
                if (!string.IsNullOrEmpty(ContraseñaTextBox.Text))
                    if (!string.IsNullOrEmpty(ConfirmarTextBox.Text))
                    {
                        if(ContraseñaTextBox.Text.Equals(ConfirmarTextBox.Text))
                        {
                            usuario = new Usuarios(UsuarioTextBox.Text, ContraseñaTextBox.Text, 1);
                            AsignarPermisos(usuario);
                            if (BLL.UsuariosBLL.Insertar(usuario))
                                MessageBox.Show("Ha registrado un nuevo 'Usuario'", "-- Transaccion Exitosa --", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("No se ha podido registrar el 'Usuario'", "-- Transaccion Fallida --", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            CleanCampos();
                        }
                        else
                        {
                            MessageBox.Show("Las contraseñas son distintas", "-- Aviso --", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            ConfirmarTextBox.Clear();
                            ContraseñaTextBox.Clear();
                            ContraseñaTextBox.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No puedes dejar campos vacíos", "-- Aviso --", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ConfirmarTextBox.Focus();
                    }
                else
                {
                    MessageBox.Show("No puedes dejar campos vacíos", "-- Aviso --", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ContraseñaTextBox.Focus();
                }

            }
            else
            {
                MessageBox.Show("No puedes dejar campos vacíos", "-- Aviso --", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UsuarioTextBox.Focus();
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Usuarios user = BLL.UsuariosBLL.Buscar(Utileria.ToInt(IdTextBox.Text));
            if (user != null)
            {
                if (BLL.UsuariosBLL.Eliminar(user))
                    MessageBox.Show("El usuario ha sido eliminado", "-- Transaccion Exitosa --", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se ha podido eliminar el usuario solicitado", "-- Transaccion Fallida --", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("El usuario no existe", "-- Consulta Fallida --", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AsignarPermisos(Usuarios usuario)
        {
            //Para Registros
            PermisosRegistro(usuario);
            //Para Consultas
            PermisosConsulta(usuario);
        }

        private void PermisosRegistro(Usuarios usuario)
        {
            if (RCertificacioncheckBox1.Checked)
                usuario.RCertificacion = 1;
            if (RComprobantecheckBox.Checked)
                usuario.RComprobante = 1;
            if (RContratocheckBox.Checked)
                usuario.RContrato = 1;
            if (REmpleadocheckBox.Checked)
                usuario.REmpleado = 1;
            if (REstadoProductocheckBox.Checked)
                usuario.REstadoProducto = 1;
            if (RFactoriacheckBox.Checked)
                usuario.RFactoria = 1;
            if (RFincacheckBox.Checked)
                usuario.RFinca = 1;
            if (RPesadacheckBox.Checked)
                usuario.RPesada = 1;
            if (RProductorescheckBox.Checked)
                usuario.RProductores = 1;
            if (RReciboRecepcioncheckBox.Checked)
                usuario.RReciboRecepcion = 1;
            if (RTipoProductocheckBox.Checked)
                usuario.RTipoProducto = 1;
            if (RTipoEmpleadocheckBox.Checked)
                usuario.RTipoEmpleado = 1;
            if (RTipoUsuariocheckBox.Checked)
                usuario.RTipoUsuario = 1;
            if (RUsuariocheckBox.Checked)
                usuario.RUsuario = 1;
        }

        private void PermisosConsulta(Usuarios usuario)
        {
            if (CCertificacioncheckBox.Checked)
                usuario.CCertificacion = 1;
            if (CComprobantecheckBox.Checked)
                usuario.CComprobante = 1;
            if (CContratocheckBox.Checked)
                usuario.CContrato = 1;
            if (CEmpleadocheckBox.Checked)
                usuario.CEmpleado = 1;
            if (CEstadoProductocheckBox.Checked)
                usuario.CEstadoProducto = 1;
            if (CFactoriacheckBox.Checked)
                usuario.CFactoria = 1;
            if (CFincacheckBox.Checked)
                usuario.CFinca = 1;
            if (CPesadacheckBox.Checked)
                usuario.CPesada = 1;
            if (CProductorescheckBox.Checked)
                usuario.CProductores = 1;
            if (CReciboRecepcioncheckBox.Checked)
                usuario.CReciboRecepcion = 1;
            if (CTipoProductocheckBox.Checked)
                usuario.CTipoProducto = 1;
            if (CTipoEmpleadocheckBox.Checked)
                usuario.CTipoEmpleado = 1;
            if (CTipoUsuariocheckBox.Checked)
                usuario.CTipoUsuario = 1;
            if (CUsuariocheckBox.Checked)
                usuario.CUsuario = 1;
        }

        private void ValidarCampos()
        {
            var val = new Utileria(IdTextBox, "Ej.: 01", UsuarioTextBox, "N");
            var val1 = new Utileria(UsuarioTextBox, "Ej.: Juan Pérez", ContraseñaTextBox, "LN");
            var val2 = new Utileria(ContraseñaTextBox, "Contraseña", ConfirmarTextBox, "LN");
            var val3 = new Utileria(ConfirmarTextBox, "Contraseña", IdTextBox, "LN");
        }

        private void CargarTiposUsuario()
        {
            while (true)
            {
                var tipos = BLL.TiposDeUsuariosBLL.GetList();
                if (tipos.Count <= 0)
                {
                    MessageBox.Show("No hay 'Tipos de Usuario' registrados", "-- Aviso --", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var ventana = new RegistroTipoUsuario();
                    ventana.ShowDialog();
                }
                else
                {
                    TipoComboBox.DataSource = tipos;
                    TipoComboBox.DisplayMember = "Nombre";
                    TipoComboBox.ValueMember = "TipoUsuarioId";
                    break;
                }
            }
        }

        private void CleanCampos()
        {
            IdTextBox.Text = "Ej.: 01";
            UsuarioTextBox.Text = "Ej.: Juan Pérez";
            ContraseñaTextBox.Text = ConfirmarTextBox.Text = "Contraseña";
            IdTextBox.ForeColor = UsuarioTextBox.ForeColor = ContraseñaTextBox.ForeColor = ConfirmarTextBox.ForeColor = Color.Silver;
            CleanPermisos();
            IdTextBox.Text = (BLL.UsuariosBLL.Identity() + 1).ToString();
            UsuarioTextBox.Focus();
            IdTextBox.ForeColor = Color.Black;
        }

        private void CleanPermisos()
        {
            CleanPermisosR();
            CleanPermisosC();
        }

        private void CleanPermisosR()
        {
            RCertificacioncheckBox1.Checked = false;
            RComprobantecheckBox.Checked = false;
            RContratocheckBox.Checked = false;
            REmpleadocheckBox.Checked = false;
            REstadoProductocheckBox.Checked = false;
            RFactoriacheckBox.Checked = false;
            RFincacheckBox.Checked = false;
            RPesadacheckBox.Checked = false;
            RProductorescheckBox.Checked = false;
            RReciboRecepcioncheckBox.Checked = false;
            RTipoProductocheckBox.Checked = false;
            RTipoEmpleadocheckBox.Checked = false;
            RTipoUsuariocheckBox.Checked = false;
            RUsuariocheckBox.Checked = false;
        }

        private void CleanPermisosC()
        {
            CCertificacioncheckBox.Checked = false;
            CComprobantecheckBox.Checked = false;
            CContratocheckBox.Checked = false;
            CEmpleadocheckBox.Checked = false;
            CEstadoProductocheckBox.Checked = false;
            CFactoriacheckBox.Checked = false;
            CFincacheckBox.Checked = false;
            CPesadacheckBox.Checked = false;
            CProductorescheckBox.Checked = false;
            CReciboRecepcioncheckBox.Checked = false;
            CTipoProductocheckBox.Checked = false;
            CTipoEmpleadocheckBox.Checked = false;
            CTipoUsuariocheckBox.Checked = false;
            CUsuariocheckBox.Checked = false;
        }

        private void MostrarPermisos(Usuarios usuario)
        {
            //Para subir los permisos de registro del usuario
            MostrarPermisosR(usuario);
            //Para subir los permisos de consulta del usuario
            MostrarPermisosC(usuario);
        }

        private void MostrarPermisosR(Usuarios usuario)
        {
            RCertificacioncheckBox1.Checked = Convert.ToBoolean(usuario.RCertificacion);
            RComprobantecheckBox.Checked = Convert.ToBoolean(usuario.RComprobante);
            RContratocheckBox.Checked = Convert.ToBoolean(usuario.RContrato);
            REmpleadocheckBox.Checked = Convert.ToBoolean(usuario.REmpleado);
            REstadoProductocheckBox.Checked = Convert.ToBoolean(usuario.REstadoProducto);
            RFactoriacheckBox.Checked = Convert.ToBoolean(usuario.RFactoria);
            RFincacheckBox.Checked = Convert.ToBoolean(usuario.RFinca);
            RPesadacheckBox.Checked = Convert.ToBoolean(usuario.RPesada);
            RProductorescheckBox.Checked = Convert.ToBoolean(usuario.RProductores);
            RReciboRecepcioncheckBox.Checked = Convert.ToBoolean(usuario.RReciboRecepcion);
            RTipoProductocheckBox.Checked = Convert.ToBoolean(usuario.RTipoProducto);
            RTipoEmpleadocheckBox.Checked = Convert.ToBoolean(usuario.RTipoEmpleado);
            RTipoUsuariocheckBox.Checked = Convert.ToBoolean(usuario.RTipoUsuario);
            RUsuariocheckBox.Checked = Convert.ToBoolean(usuario.RUsuario);
        }

        private void MostrarPermisosC(Usuarios usuario)
        {
            CCertificacioncheckBox.Checked = Convert.ToBoolean(usuario.CCertificacion);
            CComprobantecheckBox.Checked = Convert.ToBoolean(usuario.CComprobante);
            CContratocheckBox.Checked = Convert.ToBoolean(usuario.CContrato);
            CEmpleadocheckBox.Checked = Convert.ToBoolean(usuario.CEmpleado);
            CEstadoProductocheckBox.Checked = Convert.ToBoolean(usuario.CEstadoProducto);
            CFactoriacheckBox.Checked = Convert.ToBoolean(usuario.CFactoria);
            CFincacheckBox.Checked = Convert.ToBoolean(usuario.CFinca);
            CPesadacheckBox.Checked = Convert.ToBoolean(usuario.CPesada);
            CProductorescheckBox.Checked = Convert.ToBoolean(usuario.CProductores);
            CReciboRecepcioncheckBox.Checked = Convert.ToBoolean(usuario.CReciboRecepcion);
            CTipoProductocheckBox.Checked = Convert.ToBoolean(usuario.CTipoProducto);
            CTipoEmpleadocheckBox.Checked = Convert.ToBoolean(usuario.CTipoEmpleado);
            CTipoUsuariocheckBox.Checked = Convert.ToBoolean(usuario.CTipoUsuario);
            CUsuariocheckBox.Checked = Convert.ToBoolean(usuario.CUsuario);
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {
            CargarTiposUsuario();
        }
    }
}
