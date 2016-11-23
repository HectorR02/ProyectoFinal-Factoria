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

            CargarTiposEmpleados();
            CargarFactorias();
        }

        //Temporales
        private void CargarTiposEmpleados()
        {
            var te = new TiposEmpleados("Recepcionista");
            var te1 = new TiposEmpleados("Pesador");
            var te2 = new TiposEmpleados("Obrero");

            BLL.TiposEmpleadosBLL.Insertar(te);
            BLL.TiposEmpleadosBLL.Insertar(te1);
            BLL.TiposEmpleadosBLL.Insertar(te2);

            TipoEmpleadoComboBox.DataSource = BLL.TiposEmpleadosBLL.GetList();
            TipoEmpleadoComboBox.ValueMember = "TipoEmpleadoId";
            TipoEmpleadoComboBox.DisplayMember = "TipoEmpleado";
        }

        private void CargarFactorias()
        {
            var fact = new Factorias(354684, "Tenares", "La Zursa, #3 Sto. Dgo.", 8095878767);

            BLL.FactoriasBLL.Insertar(fact);

            FactoriaComboBox.DataSource = BLL.FactoriasBLL.GetList();
            FactoriaComboBox.ValueMember = "FactoriaRNC";
            FactoriaComboBox.DisplayMember = "NombreSucursal";
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Empleados nuevo = CrearEmpleado();
            if (nuevo != null)
            {
                if (BLL.EmpleadosBLL.Insertar(nuevo))
                    MessageBox.Show("Ha Registrado Un Empleado", "-- Aviso --", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No Se Ha Podido Llevar A Cabo\nLa Operación Solicitada", "-- Transacción Fallida --", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            var empleado = BLL.EmpleadosBLL.Buscar(ToInt(EmpleadoIdTextBox.Text));
            if (empleado != null)
            {
                if (BLL.EmpleadosBLL.Eliminar(empleado))
                    MessageBox.Show("Ha Eliminado Un Empleado", "-- Transacción Exitosa --", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No Se Ha Podido Llevar A Cabo\nLa Operación Solicitada", "-- Transacción Fallida --", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var Empleado = BLL.EmpleadosBLL.Buscar(ToInt(EmpleadoIdTextBox.Text));

            if(Empleado != null)
            {
                LlenarCampos(Empleado);
            }
            else
            {
                MessageBox.Show("El Empleado No Existe", "-- Transacción Fallida --", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void LlenarCampos(Empleados empleado)
        {
            NombresTextBox.Text = empleado.Nombres;
            FactoriaComboBox.SelectedValue = empleado.FactoriaRNC;
            //TipoEmpleadoComboBox.SelectedItem = empleado.TipoEmpleado;
            TipoEmpleadoComboBox.SelectedValue = empleado.TipoEmpleado;
            TipoEmpleadoComboBox.Text = empleado.TipoEmpleado;
            CedulaMaskedTextBox.Text = empleado.Cedula.ToString();
            DireccionTextBox.Text = empleado.Direccion;
            TelefonoMaskedTextBox.Text = empleado.Telefono.ToString();
        }

        private Int64 ToInt64(string texto)
        {
            Int64 numero;
            Int64.TryParse(texto, out numero);
            return numero;
        }

        private int ToInt(string texto)
        {
            int numero;
            int.TryParse(texto, out numero);
            return numero;
        }

        private Empleados CrearEmpleado()
        {
            Empleados empleado = null;
            if (!string.IsNullOrEmpty(EmpleadoIdTextBox.Text))
            {
                if (!string.IsNullOrEmpty(NombresTextBox.Text))
                {
                    if (CedulaMaskedTextBox.MaskFull)
                    {
                        if (!string.IsNullOrEmpty(DireccionTextBox.Text))
                        {
                            empleado = new Empleados();
                            var Ced = CedulaMaskedTextBox.Text.Split('-');
                            var cdula = Ced[0] + Ced[1] + Ced[2];
                            char[] separator = { '(', ')', ' ', '-' };
                            var telf = TelefonoMaskedTextBox.Text.Split(separator);
                            var Telf = telf[1] + telf[3] + telf[6];
                            empleado.Nombres = NombresTextBox.Text;
                            empleado.Cedula = ToInt64(cdula);
                            empleado.Direccion = DireccionTextBox.Text;
                            empleado.Telefono = ToInt64(Telf);
                            empleado.TipoEmpleado = "Cajero";
                            
                            empleado.FactoriaRNC = (int) FactoriaComboBox.SelectedValue;
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
            return empleado;
        }

        private void LimpiarCampos()
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
    }
}
