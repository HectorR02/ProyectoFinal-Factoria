using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Factoria.VentanasReportes
{
    public partial class ReporteContrato : Form
    {
        public ReporteContrato()
        {
            InitializeComponent();
        }

        public int NumeroDeContrato { get; set; }

        private void ReporteContrato_Load(object sender, EventArgs e)
        {
            ContratosBindingSource.Add(BLL.ContratosBLL.Buscar(NumeroDeContrato));
            this.reportViewer1.RefreshReport();
        }
    }
}
