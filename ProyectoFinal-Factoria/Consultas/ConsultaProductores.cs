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
    public partial class ConsultaProductores : Form
    {
        public ConsultaProductores()
        {
            InitializeComponent();
            BLL.ProductoresBLL.Insertar(new Productores()
            {
                ProductorId = 1,
                FactoriaRNC = 1547,
                Nombres ="Juan Perez",
                Cedula = 12365478963
            });
            BLL.ProductoresBLL.Insertar(new Productores()
            {
                ProductorId = 2,
                FactoriaRNC = 1547,
                Nombres = "Perensejo Núñez",
                Cedula = 78965412303
            });
            BLL.ProductoresBLL.Insertar(new Productores()
            {
                ProductorId = 3,
                FactoriaRNC = 1547,
                Nombres = "Albaro Perez",
                Cedula = 01236547896
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductoresDataGridView.DataSource = BLL.ProductoresBLL.GetList();
        }
    }
}
