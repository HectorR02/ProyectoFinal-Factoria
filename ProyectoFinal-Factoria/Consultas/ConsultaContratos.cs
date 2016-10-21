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
            BLL.ContratosBLL.Insertar(new Contratos()
            {
                NumeroContrato = 1,
                FechaEmision = DateTime.Today,
                Detalle = "Algo ahi",
                NombreProductor = "Jose Mendes",
                CedulaProductor = 96325874102,
                Quintales = 15,
                PrecioPorQuintal = 12554,
                FirmaAutorizada = "Juan Alberto",
                ProductorId = 2,
                FactoriaRNC = 365461321
            });
            BLL.ContratosBLL.Insertar(new Contratos()
            {
                NumeroContrato = 1,
                FechaEmision = DateTime.Today,
                Detalle = "Algo ahi",
                NombreProductor = "Joselito",
                CedulaProductor = 96325874102,
                Quintales = 15,
                PrecioPorQuintal = 12554,
                FirmaAutorizada = "Juan Alberto",
                ProductorId = 2,
                FactoriaRNC = 365461321
            });
            BLL.ContratosBLL.Insertar(new Contratos()
            {
                NumeroContrato = 1,
                FechaEmision = DateTime.Today,
                Detalle = "Algo ahi",
                NombreProductor = "Hector",
                CedulaProductor = 96325874102,
                Quintales = 15,
                PrecioPorQuintal = 12554,
                FirmaAutorizada = "Juan Alberto",
                ProductorId = 2,
                FactoriaRNC = 365461321
            });
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var contratos = BLL.ContratosBLL.GetList();
            ContratosDataGridView.DataSource = contratos;
        }
    }
}
