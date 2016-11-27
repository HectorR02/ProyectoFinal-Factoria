using Entidades;
using System;
using System.Windows.Forms;

namespace ProyectoFinal_Factoria
{
    public partial class PantallaPrincipal : Form
    {
        private Usuarios Usuario;
        private Form Login;
        public PantallaPrincipal(Usuarios usuario, Form login)
        {
            InitializeComponent();
            this.Usuario = usuario;
            this.Login = login;
            HabilitarMenus(Usuario);
        }

        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void HabilitarMenus(Usuarios usuario)
        {
            //Para Registrar
            if(usuario.RComprobante == 0)
                comprobanteDeRecepcionToolStripMenuItem.Enabled = comprobanteDeRecepciónDeCacaoToolStripMenuItem.Enabled = false;
            if(usuario.RContrato == 0)
                contratoToolStripMenuItem.Enabled = contratoToolStripMenuItem1.Enabled = false;
            if (usuario.REmpleado == 0)
                empleadoToolStripMenuItem1.Enabled = empleadoToolStripMenuItem.Enabled = false;
            if (usuario.RProductores == 0)
                productorToolStripMenuItem1.Enabled = productorToolStripMenuItem.Enabled = false;
            if (usuario.RReciboRecepcion == 0)
                reciboDeRecepciónDeProductoToolStripMenuItem.Enabled = reciboRecepciónDeProductoToolStripMenuItem.Enabled = false;
            if (usuario.RTipoUsuario == 0)
                tipoDeUsuarioToolStripMenuItem.Enabled = toolStripMenuItem2.Enabled = false;
            if (usuario.RUsuario == 0)
                usuarioToolStripMenuItem1.Enabled = usuarioToolStripMenuItem.Enabled = false;
            if (usuario.RFactoria == 0)
                factoriaToolStripMenuItem.Enabled = false;

            //Para Consultar
            if (usuario.CComprobante == 0)
                comprobanteDeRecepciónDeCacaoToolStripMenuItem1.Enabled = false;
            if (usuario.CContrato == 0)
                contratosToolStripMenuItem.Enabled = false;
            if (usuario.CReciboRecepcion == 0)
                reciboDeRecepciónDeProductoToolStripMenuItem1.Enabled = false;

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Formulario = new Registros.RegistroUsuario();
            Formulario.MdiParent = this;
            Formulario.Show();
        }
        
        private void comprobanteDeRecepciónDeCacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Formulario = new Registros.RegistroCompobanteRecepcionCacao();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void contratoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var Formulario = new Registros.RegistroContratos(Usuario);
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void empleadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var Formulario = new Registros.RegistroEmpleados();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void productorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var Formulario = new Registros.RegistroProductor();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void reciboRecepciónDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Formulario = new Registros.ConsultaReciboRecepcionProducto();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var Formulario = new Registros.RegistroTipoUsuario();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var Formulario = new Registros.RegistroUsuario();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void contratoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Formulario = new Registros.RegistroContratos(Usuario);
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void comprobanteDeRecepcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Formulario = new Registros.RegistroCompobanteRecepcionCacao();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void reciboDeRecepciónDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Formulario = new Registros.ConsultaReciboRecepcionProducto();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Formulario = new Registros.RegistroEmpleados();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void productorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Formulario = new Registros.RegistroProductor();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void tipoDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Formulario = new Registros.RegistroTipoUsuario();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void contratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Formulario = new Consultas.ConsultaContratos();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void comprobanteDeRecepciónDeCacaoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var Formulario = new Consultas.ConsultaComprobantes();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void reciboDeRecepciónDeProductoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var Formulario = new Registros.ConsultaReciboRecepcionProducto();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login.Close();
        }

        private void factoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Formulario = new Registros.RegistroFactorias();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void PantallaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login.Close();
        }
    }
}
