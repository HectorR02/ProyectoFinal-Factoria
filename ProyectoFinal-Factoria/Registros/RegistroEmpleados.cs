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

namespace ProyectoFinal_Factoria.Registros
{
    public partial class RegistroEmpleados : Form
    {
        public RegistroEmpleados()
        {
            InitializeComponent();
            var val = new Utileria(EmpleadoIdTextBox, "Ejemplo: 0001", NombresTextBox, "N");
            var val1 = new Utileria(NombresTextBox, "Ejemplo: Juan Perez", CedulaMaskedTextBox, "L");
            var val3 = new Utileria(DireccionTextBox, "Ejemplo: La Zursa, #3 Sto. Dgo.", TelefonoMaskedTextBox, "LN");

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            EmpleadoIdTextBox.Clear();
            NombresTextBox.Clear();
            CedulaMaskedTextBox.Clear();
            DireccionTextBox.Clear();
            TelefonoMaskedTextBox.Clear();
            TipoEmpleadoComboBox.SelectedItem = 1;
            FactoriaComboBox.SelectedItem = 1;
            EmpleadoIdTextBox.Focus();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(EmpleadoIdTextBox.Text))
            {
                if (!string.IsNullOrEmpty(NombresTextBox.Text))
                {
                    if(CedulaMaskedTextBox.MaskFull)
                    {
                        if (!string.IsNullOrEmpty(DireccionTextBox.Text))
                        {
                            var Ced = CedulaMaskedTextBox.Text.Split('-');
                            var cdula = Ced[0] + Ced[1] + Ced[2];
                            char[] separator = { '(', ')', ' ', '-' };
                            var telf = TelefonoMaskedTextBox.Text.Split(separator);
                            var Telf = telf[1] + telf[3] + telf[6];
                            BLL.EmpleadosBLL.Insertar(new Empleados() {
                                EmpleadoId = Convert.ToInt32(EmpleadoIdTextBox.Text),
                                Nombres = NombresTextBox.Text,
                                Cedula = Convert.ToInt64(cdula),
                                Direccion = DireccionTextBox.Text,
                                Telefono = Convert.ToInt64(Telf),
                                TipoEmpleado = "Cajero",
                                FactoriaRNC = 1
                            });
                        }else
                        {
                            DireccionTextBox.Focus();
                        }
                    }
                    else
                    {
                        CedulaMaskedTextBox.Clear();
                        CedulaMaskedTextBox.Focus();
                    }
                }
                else
                {
                    NombresTextBox.Focus();
                }
            }else
            {
                EmpleadoIdTextBox.Focus();
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EmpleadoIdTextBox.Text))
            {
                if (!string.IsNullOrEmpty(NombresTextBox.Text))
                {
                    if (CedulaMaskedTextBox.MaskFull)
                    {
                        if (!string.IsNullOrEmpty(DireccionTextBox.Text))
                        {
                            var Ced = CedulaMaskedTextBox.Text.Split('-');
                            var cdula = Ced[0] + Ced[1] + Ced[2];
                            char[] separator = { '(', ')', ' ', '-' };
                            var telf = TelefonoMaskedTextBox.Text.Split(separator);
                            var Telf = telf[1] + telf[3] + telf[6];
                            BLL.EmpleadosBLL.Eliminar(new Empleados()
                            {
                                EmpleadoId = Convert.ToInt32(EmpleadoIdTextBox.Text),
                                Nombres = NombresTextBox.Text,
                                Cedula = Convert.ToInt64(cdula),
                                Direccion = DireccionTextBox.Text,
                                Telefono = Convert.ToInt64(Telf),
                                TipoEmpleado = "Cajero",
                                FactoriaRNC = 1
                            });
                        }
                        else
                        {
                            DireccionTextBox.Focus();
                        }
                    }
                    else
                    {
                        CedulaMaskedTextBox.Clear();
                        CedulaMaskedTextBox.Focus();
                    }
                }
                else
                {
                    NombresTextBox.Focus();
                }
            }
            else
            {
                EmpleadoIdTextBox.Focus();
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EmpleadoIdTextBox.Text))
            {
                var Empleado = BLL.EmpleadosBLL.Buscar(Convert.ToInt32(EmpleadoIdTextBox.Text));
                if(Empleado != null)
                {
                    NombresTextBox.Text = Empleado.Nombres;
                    CedulaMaskedTextBox.Text = Empleado.Cedula.ToString();
                    DireccionTextBox.Text = Empleado.Direccion;
                    TelefonoMaskedTextBox.Text = Empleado.Telefono.ToString();

                }
                else
                {
                    MessageBox.Show("Este empleado no existe");
                }
            }else
            {
                EmpleadoIdTextBox.Focus();
            }
        }
    }
}
