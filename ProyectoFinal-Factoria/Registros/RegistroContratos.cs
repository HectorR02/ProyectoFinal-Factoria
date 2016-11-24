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
        public RegistroContratos()
        {
            InitializeComponent();
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
                NombreProductorTextBox.Text = contrato.NombreProductor;
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
                            if (!string.IsNullOrEmpty(NombreProductorTextBox.Text))
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
                                                nuevo.NombreProductor = NombreProductorTextBox.Text;
                                                nuevo.CedulaProductor = ToInt64(Cedula);
                                                nuevo.Quintales = ToInt(QuintalesTextBox.Text);
                                                nuevo.PrecioPorQuintal = ToDouble(PrecioXqUintalTextBox.Text);
                                                nuevo.FirmaAutorizada = FirmaAutoridadTextBox.Text;
                                                nuevo.ProductorId = ToInt(ProductorIdTextBox.Text);
                                                nuevo.FactoriaRNC = ToInt(FactoriaRNCTextBox.Text);
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
            else
            {

            }
            return nuevo;
        }

        private void LimpiarCampos()
        {
            NoContratoTextBox.Clear();
            FechaDateTimePicker.Value = DateTime.Today;
            DetallesRichTextBox.Clear();
            NombreProductorTextBox.Clear();
            CedulaProductorMaskedTextBox.Clear();
            QuintalesTextBox.Clear();
            PrecioXqUintalTextBox.Clear();
            FirmaAutoridadTextBox.Clear();
            ProductorIdTextBox.Clear();
            FactoriaRNCTextBox.Clear();
        }
    }
}
