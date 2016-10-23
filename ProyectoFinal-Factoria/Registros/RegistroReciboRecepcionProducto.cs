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
    public partial class RegistroReciboRecepcionProducto : Form
    {
        public RegistroReciboRecepcionProducto()
        {
            InitializeComponent();
            EntradaNoTextBox.Focus();
            RecibimosDeComboBox.Items.Add("Juan Perez");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(RecibimosDeComboBox.SelectedItem.ToString()) || CedulaProductorMaskedTextBox.MaskFull)
            {
                if (!string.IsNullOrEmpty(RecibimosDeComboBox.SelectedItem.ToString()) && CedulaProductorMaskedTextBox.MaskFull)
                {
                    var Ced = CedulaProductorMaskedTextBox.Text.Split('-');
                    var cdula = Ced[0] + Ced[1] + Ced[2];
                    var Comp = BLL.ComprobaanteRecepcionCacaosBLL.Buscar(RecibimosDeComboBox.SelectedItem.ToString(), Convert.ToInt64(cdula));
                    if(Comp != null)
                    {
                        AsociacionTextBox.Text = Comp.Asociacion;
                        DetalleTextBox.Text = Comp.KgBruto.ToString() + "Kg Bruto - " + Comp.TipoProducto + " - " + Comp.EstadoProducto + " - Certificacion: " + Comp.CertificacionProducto;
                        X100SacosTextBox.Text = Comp.Sacos.ToString();
                        X100MohoTextBox.Text = Comp.DescuentoMoho.ToString();
                        X100ImpurezaTextBox.Text = Comp.DescuentoBasura.ToString();
                        X100HumedadTextBox.Text = Comp.DescuentoHumedad.ToString();
                        DescSacosTextBox.Text = ((Decimal)(Comp.Sacos * 0.25)).ToString();
                        DescMohoTextBox.Text = ((Decimal)(Comp.DescuentoMoho * 0.25)).ToString();
                        DescImpurezaTextBox.Text = ((Decimal)(Comp.DescuentoBasura * 0.25)).ToString();
                        DescHumedadTextBox.Text = ((Decimal)(Comp.DescuentoHumedad * 0.25)).ToString();
                        TotalTaraTextBox.Text = (((Decimal)(Comp.Sacos * 0.25)) + ((Decimal)(Comp.DescuentoMoho * 0.25)) + ((Decimal)(Comp.DescuentoBasura * 0.25)) + ((Decimal)(Comp.DescuentoHumedad * 0.25))).ToString();
                        FechaRecepcionDateTimePicker.Value = Comp.Fecha;
                        var kilos = (Decimal)Comp.Quintales * 50 - Convert.ToDecimal(DescSacosTextBox.Text);
                        var RD = (Decimal)kilos * 120;
                        ApagarRichTextBox.AppendText(kilos + " Kilos = " + Comp.Quintales + " Quintales por valor de " + RD + " PESOS DOMINICANOS\n" + "6000.00 precio por Quintal");
                        NotasTextBox.Text = "No." + Comp.NumeroComprobante.ToString();
                        GuardarButton.Enabled = ImprimirButton.Enabled = EliminarButton.Enabled = true;
                    }
                }
            }
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            var Ced = CedulaProductorMaskedTextBox.Text.Split('-');
            var cdula = Ced[0] + Ced[1] + Ced[2];
            var Recibo = new RecibosRecepcionProductos();
            Recibo.NumeroRecibo = 1;//Convert.ToInt32(EntradaNoTextBox.Text);
            Recibo.Fecha = FechaDateTimePicker.Value;
            Recibo.NombreProductor = RecibimosDeComboBox.SelectedItem.ToString();
            Recibo.CedulaProductor = Convert.ToInt64(cdula);
            Recibo.AsociacionProductor = AsociacionTextBox.Text;
            Recibo.Detalle = DetalleTextBox.Text;
            Recibo.PorcientoSaco = Convert.ToInt32(X100SacosTextBox.Text);
            Recibo.DescuentoMoho = Convert.ToInt32(X100MohoTextBox.Text);
            Recibo.DescuentoImpureza = Convert.ToInt32(X100ImpurezaTextBox.Text);
            Recibo.PorcientoHumedad = Convert.ToInt32(X100HumedadTextBox.Text);
            Recibo.TotalTara = Convert.ToDecimal(TotalTaraTextBox.Text);
            Recibo.DescuentoSacos = Convert.ToDecimal(DescSacosTextBox.Text);
            Recibo.DescuentoMoho = Convert.ToDecimal(DescMohoTextBox.Text);
            Recibo.DescuentoImpureza = Convert.ToDecimal(DescImpurezaTextBox.Text);
            Recibo.DescuentoHumedad = Convert.ToDecimal(DescHumedadTextBox.Text);
            Recibo.FechaRecepcion = FechaRecepcionDateTimePicker.Value;
            Recibo.Apagar = ApagarRichTextBox.Text;
            Recibo.Notas = NotasTextBox.Text;
            Recibo.RecibidoPor = RecibimosDeComboBox.SelectedItem.ToString();
            Recibo.RealizadoPor = "Yorbelyn Micheel";
            Recibo.ProductorId = 1;
            Recibo.FactoriaRNC = 963214587;
            BLL.RecibosRecepcionProductosBLL.Insertar(Recibo);
            var Rep = new VentanasReportes.ReporteReciboRecepcionProducto();
            Rep.NumeroRecibo = Convert.ToInt32(EntradaNoTextBox.Text);
            Rep.Show();
        }
    }
}
