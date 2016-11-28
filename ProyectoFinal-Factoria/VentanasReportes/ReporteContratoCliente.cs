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
    public partial class ReporteContratoCliente : Form
    {
        public int FactoriaId { get; set; }
        public ReporteContratoCliente()
        {
            InitializeComponent();
        }

        private void ReporteContratoCliente_Load(object sender, EventArgs e)
        {
            foreach (var contrato in BLL.ContratosBLL.GetList(FactoriaId))
            {
                ContratosBindingSource.Add(contrato);
            }
            FactoriasBindingSource.Add(BLL.FactoriasBLL.Buscar(FactoriaId));
            this.reportViewer1.RefreshReport();
        }
    }
}
