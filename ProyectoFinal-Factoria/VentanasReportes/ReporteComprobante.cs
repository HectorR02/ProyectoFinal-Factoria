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
    public partial class ReporteComprobante : Form
    {
        public int ProductorId { get; set; }
        public ReporteComprobante()
        {
            InitializeComponent();
        }

        private void ReporteComprobante_Load(object sender, EventArgs e)
        {
            foreach (var comprobante in BLL.ComprobaanteRecepcionCacaosBLL.GetList(ProductorId))
            {
                ComprobanteRecepcionCacaosBindingSource.Add(comprobante);
            }
            ProductoresBindingSource.Add(BLL.ProductoresBLL.Buscar(ProductorId));
            this.reportViewer1.RefreshReport();
        }
    }
}
