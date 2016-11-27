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

namespace ProyectoFinal_Factoria.Consultas
{
    public partial class ConsultaContratos : Form
    {
        public ConsultaContratos()
        {
            InitializeComponent();

            CargarFactorias();
            DesdedateTimePicker.Value = HastadateTimePicker.Value = DateTime.Now;
        }

        private void CargarFactorias()
        {
            while (true)
            {
                var lista = BLL.FactoriasBLL.GetList();

                if(lista.Count() <= 0)
                {
                    MessageBox.Show("Para continuar con este proceso registre\nal menos una 'Factoria'", "-- No hay 'Factorias' registradas --", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    var ventana = new Registros.RegistroFactorias();
                    ventana.ShowDialog();
                }
                else
                {
                    FactoriascomboBox.DataSource = lista;
                    FactoriascomboBox.ValueMember = "FactoriaId";
                    FactoriascomboBox.DisplayMember = "NombreSucursal";
                    break;
                }
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var factoria = BLL.FactoriasBLL.Buscar((int)FactoriascomboBox.SelectedValue);
            var contratos = BLL.ContratosBLL.GetList(factoria.FactoriaRNC, DesdedateTimePicker.Value, HastadateTimePicker.Value);
            ContratosDataGridView.DataSource = null;
            ContratosDataGridView.DataSource = contratos;
        }
    }
}
