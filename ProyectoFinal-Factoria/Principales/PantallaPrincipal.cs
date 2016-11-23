using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Factoria
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
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

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void comprobanteDeRecepciónDeCacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Formulario = new Registros.RegistroCompobanteRecepcionCacao();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void contratoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var Formulario = new Registros.RegistroContratos();
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
            var Formulario = new Registros.RegistroReciboRecepcionProducto();
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
            var Formulario = new Registros.RegistroContratos();
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
            var Formulario = new Registros.RegistroReciboRecepcionProducto();
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
            //var Formulario = new Consultas.ConsultaContratos();
            //Formulario.MdiParent = this;
            //Formulario.Show();
        }

        private void reciboDeRecepciónDeProductoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
