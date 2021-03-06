﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoFinal_Factoria.Consultas
{
    public partial class ConsultaReciboRecepcionProducto : Form
    {
        public ConsultaReciboRecepcionProducto()
        {
            InitializeComponent();
            int id = BLL.RecibosRecepcionProductosBLL.Identity();
            if (id > 1 || BLL.RecibosRecepcionProductosBLL.GetList().Count > 0)
                EntradaNoTextBox.Text = (id + 1).ToString();
            else
                EntradaNoTextBox.Text = id.ToString();            
        }

        private void CargarProductores()
        {
            while (true)
            {
                List<Productores> lista = BLL.ProductoresBLL.GetList();
                if (lista.Count <= 0)
                {
                    MessageBox.Show("No hay productores registrados debes registrar alguno\nantes de seguir con este proceso", "-- Aviso --", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    var ventana = new Registros.RegistroProductor();
                    ventana.ShowDialog();
                }
                else
                {
                    RecibimosDeComboBox.ValueMember = "ProductorId";
                    RecibimosDeComboBox.DisplayMember = "Nombres";
                    RecibimosDeComboBox.DataSource = lista;
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Rep = new VentanasReportes.ReporteReciboRecepcionProducto();
            Rep.NumeroRecibo = Convert.ToInt32(EntradaNoTextBox.Text);
            Rep.Show();
        }

        private Int64 ToInt64(string texto)
        {
            Int64 numero;
            Int64.TryParse(texto, out numero);
            return numero;
        }

        private Decimal ToDecimal(string texto)
        {
            Decimal numero;
            Decimal.TryParse(texto, out numero);
            return numero;
        }

        private void GenerarRecibo(ComprobanteRecepcionCacaos comprobante, List<Pesadas> pesadas)
        {
            int KgBruto = 0;
            int Sacos = 0;
            foreach (var pesada in pesadas)
            {
                KgBruto += pesada.KgBruto;
                Sacos += pesada.Sacos;
            }
            AsociacionTextBox.Text = comprobante.Asociacion;
            DetalleTextBox.Text = KgBruto.ToString() + "Kg Bruto - " + comprobante.TipoProducto + " - " + comprobante.EstadoProducto + " - Certificacion: " + comprobante.CertificacionProducto;
            X100SacosTextBox.Text = Sacos.ToString();
            X100MohoTextBox.Text = comprobante.DescuentoMoho.ToString();
            X100ImpurezaTextBox.Text = comprobante.DescuentoBasura.ToString();
            X100HumedadTextBox.Text = comprobante.DescuentoHumedad.ToString();
            DescSacosTextBox.Text = ((Decimal)(Sacos * 0.25)).ToString();
            DescMohoTextBox.Text = ((Decimal)(comprobante.DescuentoMoho * 0.25)).ToString();
            DescImpurezaTextBox.Text = ((Decimal)(comprobante.DescuentoBasura * 0.25)).ToString();
            DescHumedadTextBox.Text = ((Decimal)(comprobante.DescuentoHumedad * 0.25)).ToString();
            TotalTaraTextBox.Text = (((Decimal)(Sacos * 0.25)) + ((Decimal)(comprobante.DescuentoMoho * 0.25)) + ((Decimal)(comprobante.DescuentoBasura * 0.25)) + ((Decimal)(comprobante.DescuentoHumedad * 0.25))).ToString();
            FechaRecepcionDateTimePicker.Value = comprobante.Fecha;
            var kilos = (Decimal)comprobante.TotalQuintales * 50 - ToDecimal(DescSacosTextBox.Text);
            var RD = (Decimal)kilos * 120;
            ApagarRichTextBox.AppendText(kilos + " Kilos = " + comprobante.TotalQuintales + " Quintales por valor de " + RD + " PESOS DOMINICANOS\n" + "6000.00 precio por Quintal");
            NotasTextBox.Text = "No." + comprobante.NumeroComprobante.ToString();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            
                    var Ced = CedulaProductorMaskedTextBox.Text.Split('-');
                    var cdula = Ced[0] + Ced[1] + Ced[2];
                    var comp = BLL.ComprobaanteRecepcionCacaosBLL.Buscar(RecibimosDeComboBox.Text, ToInt64(cdula), FechaDateTimePicker.Value);
                    if (comp != null)
                    {
                        var pesadas = BLL.PesadasBLL.GetList(comp.NumeroComprobante);
                        GenerarRecibo(comp, pesadas);
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
        
        private void RegistroReciboRecepcionProducto_Load(object sender, EventArgs e)
        {
            CargarProductores();
        }

        private void RecibimosDeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var productor = BLL.ProductoresBLL.Buscar((int)RecibimosDeComboBox.SelectedValue);
            if (productor != null)
            {
                CedulaProductorMaskedTextBox.Text = productor.Cedula.ToString();
            }
        }
    }
}
