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
    public partial class ReporteComprobanteRecepcionCacao : Form
    {
        public int NumeroComprobante { get; set; }

        public ReporteComprobanteRecepcionCacao()
        {
            InitializeComponent();
        }

        private void ReporteComprobanteRecepcionCacao_Load(object sender, EventArgs e)
        {
            this.ComprobanteRecepcionCacaosBindingSource.Add(BLL.ComprobaanteRecepcionCacaosBLL.Buscar(NumeroComprobante));
            foreach (var pesado in BLL.PesadasBLL.GetList(NumeroComprobante))
            {
                this.PesadasBindingSource.Add(pesado);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
