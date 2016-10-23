using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Factoria.VentanasReportes
{
    public partial class ReporteReciboRecepcionProducto : Form
    {
        public ReporteReciboRecepcionProducto()
        {
            InitializeComponent();
        }
        public int NumeroRecibo { get; set; }
        private void ReporteReciboRecepcionProducto_Load(object sender, EventArgs e)
        {
            RecibosRecepcionProductosBindingSource.Add(BLL.RecibosRecepcionProductosBLL.Buscar(NumeroRecibo));
            this.reportViewer1.RefreshReport();
        }
    }
}
