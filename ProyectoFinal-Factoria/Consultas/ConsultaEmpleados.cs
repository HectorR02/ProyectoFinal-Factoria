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
    public partial class ConsultaEmpleados : Form
    {
        public ConsultaEmpleados()
        {
            InitializeComponent();
            BLL.EmpleadosBLL.Insertar(new Empleados()
            {
                EmpleadoId = 2,
                Nombres = "Juan Ubierez",
                Cedula = 12351145874,
                Direccion = "Los ciruelitos",
                Telefono = 8296587302,
                TipoEmpleado = "Cajero",
                FactoriaRNC = 1
            });
            BLL.EmpleadosBLL.Insertar(new Empleados()
            {
                EmpleadoId = 1,
                Nombres = "Juan Perez",
                Cedula = 96325874101,
                Direccion = "Los Pepines",
                Telefono = 8096587412,
                TipoEmpleado = "Cajero",
                FactoriaRNC = 1
            });
            BLL.EmpleadosBLL.Insertar(new Empleados()
            {
                EmpleadoId = 3,
                Nombres = "Hector Perez",
                Cedula = 96325878741,
                Direccion = "Los Alamos",
                Telefono = 8096587498,
                TipoEmpleado = "Cajero",
                FactoriaRNC = 1
            });
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var Empleados = BLL.EmpleadosBLL.GetList();
            EmpleadosDataGridView.DataSource = Empleados;
        }
    }
}
