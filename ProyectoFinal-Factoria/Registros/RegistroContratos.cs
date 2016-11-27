using Entidades;
using ProyectoFinal_Factoria.VentanasReportes;
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
    public partial class RegistroContratos : Form
    {
        public Usuarios logueado;
        public RegistroContratos(Usuarios user)
        {
            InitializeComponent();
            logueado = user;

            ValidarCampos();
            LimpiarCampos();
            CargarProductores();
        }

        //Eventos para los botones del formulario
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (CrearContrato() != null)
                if (BLL.ContratosBLL.Insertar(CrearContrato()))
                {
                    var rep = new ReporteContrato();
                    rep.NumeroDeContrato = BLL.ContratosBLL.Identity();
                    rep.Show();
                }
            LimpiarCampos();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (BLL.ContratosBLL.Buscar(ToInt(NoContratoTextBox.Text)) != null)
            {
                string mensaje = "No Se Ha Podido Llevar A Cabo La \nOperacion Solicidada";
                string titulo = "-- Transaccion Fallida --";
                if (BLL.ContratosBLL.Eliminar(BLL.ContratosBLL.Buscar(ToInt(NoContratoTextBox.Text))))
                {
                    mensaje = "Se Ha Eliminado Un Contrato";
                    titulo = "-- Transaccion Exitosa --";
                    MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                    MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("El Contrato No Existe", "-- Aviso --", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var contrato = BLL.ContratosBLL.Buscar(Convert.ToInt32(NoContratoTextBox.Text));
            if (contrato != null)
            {
                FechaDateTimePicker.Value = contrato.FechaEmision;
                DetallesRichTextBox.Text = contrato.Detalle;
                ProductorescomboBox.Text = contrato.NombreProductor;
                CedulaProductorMaskedTextBox.Text = contrato.CedulaProductor.ToString();
                QuintalesTextBox.Text = contrato.Quintales.ToString();
                PrecioXqUintalTextBox.Text = contrato.PrecioPorQuintal.ToString();
                FirmaAutoridadTextBox.Text = contrato.FirmaAutorizada;
                ProductorIdTextBox.Text = contrato.ProductorId.ToString();
                FactoriaRNCTextBox.Text = contrato.FactoriaRNC.ToString();
            }
            else
            {
                MessageBox.Show("No existe");
            }
        }

        //Metodos para menejo de datos
        private Double ToDouble(string texto)
        {
            Double numero;
            Double.TryParse(texto, out numero);
            return numero;
        }

        private int ToInt(string texto)
        {
            int numero;
            int.TryParse(texto, out numero);
            return numero;
        }

        private Int64 ToInt64(string texto)
        {
            Int64 numero;
            Int64.TryParse(texto, out numero);
            return numero;
        }

        private Contratos CrearContrato()
        {
            Contratos nuevo = null;
            if (!string.IsNullOrEmpty(NoContratoTextBox.Text))
                if (!string.IsNullOrEmpty(FactoriaRNCTextBox.Text))
                    if (!string.IsNullOrEmpty(FirmaAutoridadTextBox.Text))
                        if (!string.IsNullOrEmpty(ProductorIdTextBox.Text))
                            if (CedulaProductorMaskedTextBox.MaskFull)
                                if (!string.IsNullOrEmpty(QuintalesTextBox.Text))
                                    if (!string.IsNullOrEmpty(PrecioXqUintalTextBox.Text))
                                        if (!string.IsNullOrEmpty(DetallesRichTextBox.Text))
                                        {
                                            nuevo = new Contratos();
                                            char[] separator = { '(', ')', ' ', '-' };
                                            var Ced = CedulaProductorMaskedTextBox.Text.Split(separator);
                                            var Cedula = Ced[0] + Ced[1] + Ced[2];
                                            nuevo.FechaEmision = FechaDateTimePicker.Value;
                                            nuevo.Detalle = DetallesRichTextBox.Text;
                                            nuevo.NombreProductor = ProductorescomboBox.Text;
                                            nuevo.CedulaProductor = ToInt64(Cedula);
                                            nuevo.Quintales = ToInt(QuintalesTextBox.Text);
                                            nuevo.PrecioPorQuintal = ToDouble(PrecioXqUintalTextBox.Text);
                                            nuevo.FirmaAutorizada = FirmaAutoridadTextBox.Text;
                                            nuevo.ProductorId = ToInt(ProductorIdTextBox.Text);
                                            nuevo.FactoriaRNC = ToInt(FactoriaRNCTextBox.Text);
                                            nuevo.NumeroContrato = ToInt(NoContratoTextBox.Text);
                                        }
                                        else
                                        {

                                        }
                                    else
                                    {

                                    }
                                else
                                {

                                }
                            else
                            {

                            }
                        else
                        {

                        }
                    else
                    {

                    }
                else
                {

                }
            else
            {

            }
            return nuevo;
        }

        private void LimpiarCampos()
        {
            int numeroContrato = BLL.ContratosBLL.Identity();
            FactoriaRNCTextBox.Text = BLL.FactoriasBLL.RNC(logueado.FactoriaId).ToString();
            NoContratoTextBox.Clear();
            FechaDateTimePicker.Value = DateTime.Today;
            DetallesRichTextBox.Clear();
            CedulaProductorMaskedTextBox.Clear();
            QuintalesTextBox.Clear();
            PrecioXqUintalTextBox.Clear();
            FirmaAutoridadTextBox.Clear();
            ProductorIdTextBox.Clear();
            if (numeroContrato > 1 || BLL.ContratosBLL.GetList().Count > 0)
                NoContratoTextBox.Text = (numeroContrato + 1).ToString();
            else
                NoContratoTextBox.Text = numeroContrato.ToString();

        }

        private void CargarProductores()
        {
            while (true)
            {
                var lista = BLL.ProductoresBLL.GetList();
                if (lista.Count <= 0)
                {
                    MessageBox.Show("No hay 'Productores' registrados, debes registrar alguno\nantes de seguir con este proceso", "-- Aviso --", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    var ventana = new RegistroProductor();
                    ventana.ShowDialog();
                }
                else
                {
                    ProductorescomboBox.ValueMember = "ProductorId";
                    ProductorescomboBox.DisplayMember = "Nombres";
                    ProductorescomboBox.DataSource = lista;
                    break;
                }
            }
        }

        private void ValidarCampos()
        {
            var val = new Utileria(NoContratoTextBox, "Ej.: 0001", FirmaAutoridadTextBox, "N");
            var val1 = new Utileria(FirmaAutoridadTextBox, "Ej.: Jose González", QuintalesTextBox, "L");
            var val2 = new Utileria(QuintalesTextBox, "Ej.: 13", PrecioXqUintalTextBox, "N");
            var val3 = new Utileria(PrecioXqUintalTextBox, "Ej.: 13", DetallesRichTextBox, "LN");
        }

        private void ProductorescomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if(ProductorescomboBox.DataSource != null)
            {
                Productores productor = BLL.ProductoresBLL.Buscar((int)ProductorescomboBox.SelectedValue);
                if(productor != null)
                {
                    ProductorIdTextBox.Text = productor.ProductorId.ToString();
                    CedulaProductorMaskedTextBox.Text = productor.Cedula.ToString();
                }
                else
                {
                    MessageBox.Show("No se encontro");
                }
            }
        }
    }
}
