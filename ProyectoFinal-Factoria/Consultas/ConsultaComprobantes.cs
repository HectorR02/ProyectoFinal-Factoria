using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Factoria.Consultas
{
    public partial class ConsultaComprobantes : Form
    {
        public ConsultaComprobantes()
        {
            InitializeComponent();

            CargarProductores();
        }

        private void CargarProductores()
        {
            while (true)
            {
                var lista = BLL.ProductoresBLL.GetList();
                if (lista.Count() <= 0)
                {
                    MessageBox.Show("Por favor, registre al menos 1 'Productor' antes\nde continuar con este proceso", "-- No Hay Productores Registrados --", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    var ventana = new Registros.RegistroProductor();
                    ventana.ShowDialog();
                }else
                {
                    ProductorescomboBox.DataSource = lista;
                    ProductorescomboBox.ValueMember = "ProductorId";
                    ProductorescomboBox.DisplayMember = "Nombres";
                    break;
                }
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            var lista = BLL.ComprobaanteRecepcionCacaosBLL.GetList((int)ProductorescomboBox.SelectedValue, DesdedateTimePicker.Value, HastadateTimePicker.Value);
            ComprobantesdataGridView.DataSource = null;
            ComprobantesdataGridView.DataSource = lista;

            
        }
    }
}
