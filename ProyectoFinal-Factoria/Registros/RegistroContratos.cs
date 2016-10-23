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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NuevoButton_Click(object sender, EventArgs e)
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

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(NoContratoTextBox.Text))
            {
                if (!string.IsNullOrEmpty(FactoriaRNCTextBox.Text))
                {
                    if (!string.IsNullOrEmpty(FirmaAutoridadTextBox.Text))
                    {
                        if (!string.IsNullOrEmpty(ProductorIdTextBox.Text))
                        {
                            if (!string.IsNullOrEmpty(NombreProductorTextBox.Text))
                            {
                                if (CedulaProductorMaskedTextBox.MaskFull)
                                {
                                    if (!string.IsNullOrEmpty(QuintalesTextBox.Text))
                                    {
                                        if (!string.IsNullOrEmpty(PrecioXqUintalTextBox.Text))
                                        {
                                            if (!string.IsNullOrEmpty(DetallesRichTextBox.Text))
                                            {
                                                char[] separator = { '(', ')', ' ', '-' };
                                                var Ced = CedulaProductorMaskedTextBox.Text.Split(separator);
                                                var Cedula = Ced[0] + Ced[1] + Ced[2];
                                                BLL.ContratosBLL.Insertar(new Contratos() {
                                                    NumeroContrato = 1,
                                                    FechaEmision = FechaDateTimePicker.Value,
                                                    Detalle = DetallesRichTextBox.Text,
                                                    NombreProductor = NombreProductorTextBox.Text,
                                                    CedulaProductor = Convert.ToInt64(Cedula),
                                                    Quintales = Convert.ToInt32(QuintalesTextBox.Text),
                                                    PrecioPorQuintal = Convert.ToDecimal(PrecioXqUintalTextBox.Text),
                                                    FirmaAutorizada = FirmaAutoridadTextBox.Text,
                                                    ProductorId = Convert.ToInt32(ProductorIdTextBox.Text),
                                                    FactoriaRNC = Convert.ToInt32(FactoriaRNCTextBox.Text)
                                                });
                                                var rep = new ReporteContrato();
                                                rep.NumeroDeContrato = 1;
                                                rep.Show();
                                            }
                                            else
                                            {

                                            }
                                        }else
                                        {

                                        }
                                    }else
                                    {

                                    }
                                }else
                                {

                                }
                            }else
                            {

                            }
                        }else
                        {

                        }
                    }else
                    {

                    }
                }
                else
                {

                }
            }
            else { }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NoContratoTextBox.Text))
            {
                if (!string.IsNullOrEmpty(FactoriaRNCTextBox.Text))
                {
                    if (!string.IsNullOrEmpty(FirmaAutoridadTextBox.Text))
                    {
                        if (!string.IsNullOrEmpty(ProductorIdTextBox.Text))
                        {
                            if (!string.IsNullOrEmpty(NombreProductorTextBox.Text))
                            {
                                if (CedulaProductorMaskedTextBox.MaskFull)
                                {
                                    if (!string.IsNullOrEmpty(QuintalesTextBox.Text))
                                    {
                                        if (!string.IsNullOrEmpty(PrecioXqUintalTextBox.Text))
                                        {
                                            if (!string.IsNullOrEmpty(DetallesRichTextBox.Text))
                                            {
                                                char[] separator = { '(', ')', ' ', '-' };
                                                var Ced = CedulaProductorMaskedTextBox.Text.Split(separator);
                                                var Cedula = Ced[0] + Ced[1] + Ced[2];
                                                BLL.ContratosBLL.Eliminar(new Contratos()
                                                {
                                                    NumeroContrato = Convert.ToInt32(NoContratoTextBox.Text),
                                                    FechaEmision = FechaDateTimePicker.Value,
                                                    Detalle = DetallesRichTextBox.Text,
                                                    NombreProductor = NombreProductorTextBox.Text,
                                                    CedulaProductor = Convert.ToInt64(Cedula),
                                                    Quintales = Convert.ToInt32(QuintalesTextBox.Text),
                                                    PrecioPorQuintal = Convert.ToDecimal(PrecioXqUintalTextBox.Text),
                                                    FirmaAutorizada = FirmaAutoridadTextBox.Text,
                                                    ProductorId = Convert.ToInt32(ProductorIdTextBox.Text),
                                                    FactoriaRNC = Convert.ToInt32(FactoriaRNCTextBox.Text)
                                                });
                                            }
                                            else
                                            {

                                            }
                                        }
                                        else
                                        {

                                        }
                                    }
                                    else
                                    {

                                    }
                                }
                                else
                                {

                                }
                            }
                            else
                            {

                            }
                        }
                        else
                        {

                        }
                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }
            else { }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(NoContratoTextBox.Text))
            {
                var contrato = BLL.ContratosBLL.Buscar(Convert.ToInt32(NoContratoTextBox.Text));
                if(contrato != null)
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
            }else {
            }
        }
    }
}
