using Entidades;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFinal_Factoria.Registros
{
    public partial class RegistroEmpleados : Form
    {
        public RegistroEmpleados()
        {
            InitializeComponent();

            Validaciones();
            CargarTiposEmpleados();
            CargarFactorias();
            LimpiarCampos();
        }

        private void Validaciones()
        {
            var val = new Utileria(EmpleadoIdTextBox, "Ejemplo: 0001", NombresTextBox, "N");
            var val1 = new Utileria(NombresTextBox, "Ejemplo: Juan Perez", CedulaMaskedTextBox, "L");
            var val3 = new Utileria(DireccionTextBox, "Ejemplo: La Zursa, #3 Sto. Dgo.", TelefonoMaskedTextBox, "LN");
        }

        private void CargarTiposEmpleados()
        {
            var lista = BLL.TiposEmpleadosBLL.GetList();
            if(lista.Count() <= 0)
            {
                var te = new TiposEmpleados("Recepcionista");
                var te1 = new TiposEmpleados("Pesador");
                var te2 = new TiposEmpleados("Obrero");

                BLL.TiposEmpleadosBLL.Insertar(te);
                BLL.TiposEmpleadosBLL.Insertar(te1);
                BLL.TiposEmpleadosBLL.Insertar(te2);
                lista = BLL.TiposEmpleadosBLL.GetList();
            }

            TipoEmpleadoComboBox.DataSource = lista;
            TipoEmpleadoComboBox.ValueMember = "TipoEmpleadoId";
            TipoEmpleadoComboBox.DisplayMember = "TipoEmpleado";
        }

        private void CargarFactorias()
        {
            while(true)
            {
                var lista = BLL.FactoriasBLL.GetList();

                if (lista.Count() <= 0)
                {
                    var ventana = new RegistroFactorias();
                    ventana.ShowDialog();
                    lista = BLL.FactoriasBLL.GetList();
                }
                else
                {
                    FactoriaComboBox.DataSource = lista;
                    FactoriaComboBox.ValueMember = "FactoriaRNC";
                    FactoriaComboBox.DisplayMember = "NombreSucursal";
                    break;
                }
            }
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
                            empleado.EmpleadoId = ToInt(EmpleadoIdTextBox.Text);
                            
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
            int id = BLL.EmpleadosBLL.Identity();
            EmpleadoIdTextBox.Clear();
            NombresTextBox.Clear();
            CedulaMaskedTextBox.Clear();
            DireccionTextBox.Clear();
            TelefonoMaskedTextBox.Clear();
            TipoEmpleadoComboBox.SelectedItem = 1;
            FactoriaComboBox.SelectedItem = 1;
            if (id > 1 || BLL.EmpleadosBLL.GetList().Count > 0)
                EmpleadoIdTextBox.Text = (id + 1).ToString();
            else
                EmpleadoIdTextBox.Text = id.ToString();
            NombresTextBox.Focus();
        }
    }
}
