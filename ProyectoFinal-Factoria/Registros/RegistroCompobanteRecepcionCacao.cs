using Entidades;
using System;
using System.Windows.Forms;

namespace ProyectoFinal_Factoria.Registros
{
    public partial class RegistroCompobanteRecepcionCacao : Form
    {
        private int factor = 126;
        public RegistroCompobanteRecepcionCacao()
        {
            InitializeComponent();
            Validaciones();
            CargarTipoProducto();
            CargarCertificacionProd();
            CargarEstadoProd();
            ProductorComboBox.Items.Add("Juan Perez");
            FactorTextBox.Text = FactorTextBox1.Text = FactorTextBox2.Text = FactorTextBox3.Text = FactorTextBoxTotal.Text = factor.ToString();
        }
//         Temporales
        private void CargarTipoProducto()
        {
            var tp = new TipoProductos();
            tp.Tipo = "Sanchez";
            BLL.TipoProductosBLL.Insertar(tp);
            tp.Tipo = "Hispaniola";
            BLL.TipoProductosBLL.Insertar(tp);
            foreach (TipoProductos TP in BLL.TipoProductosBLL.GetList())
                TipoProductoComboBox.Items.Add(TP.Tipo);
        }

        private void  CargarCertificacionProd()
        {
            var CCFP = new CertificacionProductos();
            CCFP.Certificacion = "Orgánico";
            BLL.CertificacionProductosBLL.Insertar(CCFP);
            CCFP.Certificacion = "Rain Forest";
            BLL.CertificacionProductosBLL.Insertar(CCFP);
            CCFP.Certificacion = "UTZ";
            BLL.CertificacionProductosBLL.Insertar(CCFP);
            CCFP.Certificacion = "FLO";
            BLL.CertificacionProductosBLL.Insertar(CCFP);
            CCFP.Certificacion = "Convencional";
            BLL.CertificacionProductosBLL.Insertar(CCFP);
            CCFP.Certificacion = "Ninguna";
            BLL.CertificacionProductosBLL.Insertar(CCFP);
            foreach (CertificacionProductos Ccfp in BLL.CertificacionProductosBLL.GetList())
                CertificacionProductoComboBox.Items.Add(Ccfp.Certificacion);
        }

        private void CargarEstadoProd()
        {
            var CEP = new EstadoProductos();

            CEP.Estado = "Baba";
            BLL.EstadoProductosBLL.Insertar(CEP);
            CEP.Estado = "Fermentado";
            BLL.EstadoProductosBLL.Insertar(CEP);
            CEP.Estado = "Seco";
            BLL.EstadoProductosBLL.Insertar(CEP);
            CEP.Estado = "Con Gomo";
            BLL.EstadoProductosBLL.Insertar(CEP);
            CEP.Estado = "Oreado";
            BLL.EstadoProductosBLL.Insertar(CEP);
            foreach (EstadoProductos ET in BLL.EstadoProductosBLL.GetList())
                EstadoProductoComboBox.Items.Add(ET.Estado);
        }

        private void Validaciones()
        {
            var val = new Utileria(NumeroComprobanteTextBox, "Ejemplo: 001", AsociacionTextBox, "N");
            var val1 = new Utileria(AsociacionTextBox, "Ejemplo: Productores Independientes", ProductorIdTextBox, "LN");
            var val2 = new Utileria(ProductorIdTextBox, "Ejemplo: 001", CedulaMaskedTextBox, "N");

            var val3 = new Utileria(SacosTextBox, "Ej.: 1", CamionLlenoTextBox, "N");
            var val4 = new Utileria(CamionLlenoTextBox, "Ej.: 400", CamionVacioTextBox, "N");
            var val5 = new Utileria(CamionVacioTextBox, "Ej.: 250", KgBrutoTextBox, "N");
            var val6 = new Utileria(KgBrutoTextBox, "Ej.: 150", FactorTextBox, "N");
            var val7 = new Utileria(FactorTextBox, "Ej.: 126", QuinSecosTextBox, "N");
            var val8 = new Utileria(QuinSecosTextBox, "Ej.: 1.19", ChoferTextBox, "N");

            var val9 = new Utileria(ChoferTextBox, "Ejemplo: Juan Perez", TipoTransporteTextBox, "L");
            var val10 = new Utileria(TipoTransporteTextBox, "Ejemplo: Juan Perez", PlacaTextBox, "LN");
            var val11 = new Utileria(PlacaTextBox, "Ejemplo: GMX-154", ZonaTextBox, "LN");
            var val12 = new Utileria(ZonaTextBox, "Ejemplo: El Cercado", NumeroComprobanteTextBox, "LN");

            var val13 = new Utileria(SacosTextBox1, "Ej.: 1", CamionLlenoTextBox1, "N");
            var val14 = new Utileria(CamionLlenoTextBox1, "Ej.: 400", CamionVacioTextBox1, "N");
            var val15 = new Utileria(CamionVacioTextBox1, "Ej.: 250", KgBrutoTextBox1, "N");
            var val16 = new Utileria(KgBrutoTextBox1, "Ej.: 150", FactorTextBox1, "N");
            var val17 = new Utileria(FactorTextBox1, "Ej.: 126", QuinSecosTextBox1, "N");
            var val18 = new Utileria(QuinSecosTextBox1, "Ej.: 1.19", ChoferTextBox, "N");

            var val19 = new Utileria(SacosTextBox2, "Ej.: 1", CamionLlenoTextBox2, "N");
            var val20 = new Utileria(CamionLlenoTextBox2, "Ej.: 400", CamionVacioTextBox2, "N");
            var val21 = new Utileria(CamionVacioTextBox2, "Ej.: 250", KgBrutoTextBox2, "N");
            var val22 = new Utileria(KgBrutoTextBox2, "Ej.: 150", FactorTextBox2, "N");
            var val23 = new Utileria(FactorTextBox2, "Ej.: 126", QuinSecosTextBox2, "N");
            var val24 = new Utileria(QuinSecosTextBox2, "Ej.: 1.19", ChoferTextBox, "N");

            var val25 = new Utileria(SacosTextBox3, "Ej.: 1", CamionLlenoTextBox3, "N");
            var val26 = new Utileria(CamionLlenoTextBox3, "Ej.: 400", CamionVacioTextBox3, "N");
            var val27 = new Utileria(CamionVacioTextBox3, "Ej.: 250", KgBrutoTextBox3, "N");
            var val28 = new Utileria(KgBrutoTextBox3, "Ej.: 150", FactorTextBox3, "N");
            var val29 = new Utileria(FactorTextBox3, "Ej.: 126", QuinSecosTextBox3, "N");
            var val30 = new Utileria(QuinSecosTextBox3, "Ej.: 1.19", ChoferTextBox, "N");

            var val31 = new Utileria(HumedadTextBox, "Ej.: 2", BasuraTextBox, "N");
            var val32 = new Utileria(BasuraTextBox, "Ej.: 3", MohoTextBox, "N");
            var val33 = new Utileria(MohoTextBox, "Ej.: 4", ChoferTextBox, "N");
        }

//          Fin Temporales
        private void RegistroCompobanteRecepcionCacao_Load(object sender, EventArgs e)
        {

        }

        private void LimpiarCampos()
        {
            NumeroComprobanteTextBox.Clear();
            FechaDateTimePicker.Value = DateTime.Today;
            AsociacionTextBox.Clear();
            ProductorIdTextBox.Clear();
            ProductorComboBox.SelectedIndex = 0;
            CedulaMaskedTextBox.Clear();
            TipoProductoComboBox.SelectedIndex = 0;
            CertificacionProductoComboBox.SelectedIndex = 0;
            EstadoProductoComboBox.SelectedIndex = 0;
            HumedadTextBox.Clear();
            BasuraTextBox.Clear();
            MohoTextBox.Clear();
            ChoferTextBox.Clear();
            PlacaTextBox.Clear();
            ZonaTextBox.Clear();
            TipoTransporteTextBox.Clear();

            SacosTextBox.Clear();
            CamionLlenoTextBox.Clear();
            CamionVacioTextBox.Clear();
            KgBrutoTextBox.Clear();
            FactorTextBox.Clear();
            QuinSecosTextBox.Clear();

            SacosTextBox1.Clear();
            CamionLlenoTextBox1.Clear();
            CamionVacioTextBox1.Clear();
            KgBrutoTextBox1.Clear();
            FactorTextBox1.Clear();
            QuinSecosTextBox1.Clear();

            SacosTextBox2.Clear();
            CamionLlenoTextBox2.Clear();
            CamionVacioTextBox2.Clear();
            KgBrutoTextBox2.Clear();
            FactorTextBox2.Clear();
            QuinSecosTextBox2.Clear();

            SacosTextBox3.Clear();
            CamionLlenoTextBox3.Clear();
            CamionVacioTextBox3.Clear();
            KgBrutoTextBox3.Clear();
            FactorTextBox3.Clear();
            QuinSecosTextBox3.Clear();

            SacosTextBoxTotal.Clear();
            CamionLlenoTextBoxTotal.Clear();
            CamionVacioTextBoxTotal.Clear();
            KgBrutoTextBoxTotal.Clear();
            FactorTextBoxTotal.Clear();
            QuinSecosTextBoxTotal.Clear();

            SacosTextBox.ReadOnly = SacosTextBox1.ReadOnly = SacosTextBox2.ReadOnly = SacosTextBox3.ReadOnly = CamionLlenoTextBox.ReadOnly = CamionLlenoTextBox1.ReadOnly = CamionLlenoTextBox2.ReadOnly = CamionLlenoTextBox3.ReadOnly = CamionVacioTextBox.ReadOnly = CamionVacioTextBox1.ReadOnly = CamionVacioTextBox2.ReadOnly = CamionVacioTextBox3.ReadOnly = KgBrutoTextBox.ReadOnly = KgBrutoTextBox1.ReadOnly = KgBrutoTextBox2.ReadOnly = KgBrutoTextBox3.ReadOnly = FactorTextBox.ReadOnly = FactorTextBox1.ReadOnly = FactorTextBox2.ReadOnly = FactorTextBox3.ReadOnly = QuinSecosTextBox.ReadOnly = QuinSecosTextBox1.ReadOnly = QuinSecosTextBox2.ReadOnly = QuinSecosTextBox3.ReadOnly = false;
            FactorTextBox.Text = FactorTextBox1.Text = FactorTextBox2.Text = FactorTextBox3.Text = FactorTextBoxTotal.Text = factor.ToString();
            SacosTextBox.ReadOnly = SacosTextBox1.ReadOnly = SacosTextBox2.ReadOnly = SacosTextBox3.ReadOnly = false;
            CamionLlenoTextBox.ReadOnly = CamionLlenoTextBox1.ReadOnly = CamionLlenoTextBox2.ReadOnly = CamionLlenoTextBox3.ReadOnly = false;
            CamionVacioTextBox.ReadOnly = CamionVacioTextBox1.ReadOnly = CamionVacioTextBox2.ReadOnly = CamionVacioTextBox3.ReadOnly = false;
            KgBrutoTextBox.ReadOnly = KgBrutoTextBox1.ReadOnly = KgBrutoTextBox2.ReadOnly = KgBrutoTextBox3.ReadOnly = false;

            NumeroComprobanteTextBox.Focus();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NumeroComprobanteTextBox.Text))
            {
                if (!string.IsNullOrEmpty(ProductorIdTextBox.Text))
                {
                    if (CedulaMaskedTextBox.MaskFull)
                    {
                        if (!string.IsNullOrEmpty(SacosTextBoxTotal.Text))
                        {
                            if (!string.IsNullOrEmpty(KgBrutoTextBoxTotal.Text))
                            {
                                if (!string.IsNullOrEmpty(FactorTextBoxTotal.Text))
                                {
                                    if (!string.IsNullOrEmpty(TipoTransporteTextBox.Text))
                                    {
                                        if (!string.IsNullOrEmpty(ChoferTextBox.Text))
                                        {
                                            if (!string.IsNullOrEmpty(ZonaTextBox.Text))
                                            {
                                                var Ced = CedulaMaskedTextBox.Text.Split('-');
                                                var cdula = Ced[0] + Ced[1] + Ced[2];
                                                var Comprobante = new ComprobanteRecepcionCacaos();
                                                Comprobante.NumeroComprobante = Convert.ToInt32(NumeroComprobanteTextBox.Text);
                                                Comprobante.Fecha = FechaDateTimePicker.Value;
                                                if (!string.IsNullOrEmpty(AsociacionTextBox.Text))
                                                    Comprobante.Asociacion = AsociacionTextBox.Text;
                                                Comprobante.ProductorId = Convert.ToInt32(ProductorIdTextBox.Text);
                                                Comprobante.NombreProductor = ProductorComboBox.SelectedItem.ToString();
                                                Comprobante.CedulaProductor = Convert.ToInt64(cdula);
                                                Comprobante.TipoProducto = TipoProductoComboBox.SelectedItem.ToString();
                                                Comprobante.CertificacionProducto = CertificacionProductoComboBox.SelectedItem.ToString();
                                                Comprobante.EstadoProducto = EstadoProductoComboBox.SelectedItem.ToString();
                                                Comprobante.Sacos = Convert.ToInt32(SacosTextBoxTotal.Text);
                                                if (!string.IsNullOrEmpty(CamionLlenoTextBoxTotal.Text))
                                                    Comprobante.CamionLleno = Convert.ToInt64(CamionLlenoTextBoxTotal.Text);
                                                if (!string.IsNullOrEmpty(CamionVacioTextBoxTotal.Text))
                                                    Comprobante.CamionVacio = Convert.ToInt64(CamionVacioTextBoxTotal.Text);
                                                Comprobante.KgBruto = Convert.ToDecimal(KgBrutoTextBoxTotal.Text);
                                                Comprobante.FactorConversion = Convert.ToDecimal(FactorTextBoxTotal.Text);
                                                Comprobante.Quintales = Convert.ToDecimal(QuinSecosTextBoxTotal.Text);
                                                if (!string.IsNullOrEmpty(HumedadTextBox.Text) && !HumedadTextBox.Text.Equals("Ej.: 2"))
                                                    Comprobante.DescuentoHumedad = Convert.ToInt32(HumedadTextBox.Text);
                                                if (!string.IsNullOrEmpty(BasuraTextBox.Text) && !BasuraTextBox.Text.Equals("Ej.: 3"))
                                                    Comprobante.DescuentoBasura = Convert.ToInt32(BasuraTextBox.Text);
                                                if (!string.IsNullOrEmpty(MohoTextBox.Text) && !MohoTextBox.Text.Equals("Ej.: 4"))
                                                    Comprobante.DescuentoMoho = Convert.ToInt32(MohoTextBox.Text);
                                                Comprobante.NombreChofer = ChoferTextBox.Text;
                                                Comprobante.TipoTransporte = TipoTransporteTextBox.Text;
                                                Comprobante.ZonaProcedencia = ZonaTextBox.Text;
                                                if (!string.IsNullOrEmpty(PlacaTextBox.Text))
                                                    Comprobante.PlacaVehiculo = PlacaTextBox.Text;
                                                Comprobante.RecibidoPor = "Santiago Perez";
                                                Comprobante.EntregadoPor = ChoferTextBox.Text;
                                                BLL.ComprobaanteRecepcionCacaosBLL.Insertar(Comprobante);
                                                //this.Hide();
                                                var Rep = new VentanasReportes.ReporteComprobanteRecepcionCacao();
                                                Rep.NumeroComprobante = Convert.ToInt32(NumeroComprobanteTextBox.Text);
                                                Rep.Show();
                                            }
                                            else { }
                                        }
                                        else
                                        {

                                        }
                                    }
                                    else { }
                                }
                                else { }
                            }
                            else
                            { }
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

        private void ValidacionPesada(TextBox Campo, TextBox Destino, string Texto, KeyPressEventArgs e)
        {
            if (!string.IsNullOrEmpty(Campo.Text) && !Campo.Text.Equals(Texto))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if(!Campo.ReadOnly)
                    {
                        if (string.IsNullOrEmpty(Destino.Text))
                            Destino.Text = Campo.Text;
                        else
                        {
                            int val = Convert.ToInt32(Destino.Text) + Convert.ToInt32(Campo.Text);
                            Destino.Text = val.ToString();
                        }
                    }
                    Campo.ReadOnly = true;
                }
            }
        }

        private void SacosTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionPesada(SacosTextBox, SacosTextBoxTotal,"Ej.: 1", e);
        }

        private void SacosTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionPesada(SacosTextBox1, SacosTextBoxTotal, "Ej.: 1", e);
        }

        private void CamionLlenoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionPesada(CamionLlenoTextBox, CamionLlenoTextBoxTotal, "Ej.: 400", e);            
        }

        private void CamionVacioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionPesada(CamionVacioTextBox, CamionVacioTextBoxTotal, "Ej.: 250", e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                if(!string.IsNullOrEmpty(CamionLlenoTextBox.Text) && !CamionLlenoTextBox.Text.Equals("Ej.: 400"))
                {
                    if(!string.IsNullOrEmpty(CamionVacioTextBox.Text) && !CamionVacioTextBox.Text.Equals("Ej.: 250"))
                    {
                        KgBrutoTextBox.Text = (Convert.ToInt32(CamionLlenoTextBox.Text) - Convert.ToInt32(CamionVacioTextBox.Text)).ToString();
                        float val = (Convert.ToSingle(KgBrutoTextBox.Text) / factor);                        
                        QuinSecosTextBox.Text = val.ToString();
                        KgBrutoTextBox.ReadOnly = true;
                        if (string.IsNullOrEmpty(KgBrutoTextBoxTotal.Text))
                            KgBrutoTextBoxTotal.Text = KgBrutoTextBox.Text;
                        else
                        {
                            int val1 = Convert.ToInt32(KgBrutoTextBoxTotal.Text) + Convert.ToInt32(KgBrutoTextBox.Text);
                            KgBrutoTextBoxTotal.Text = val1.ToString();
                        }

                        if (string.IsNullOrEmpty(QuinSecosTextBoxTotal.Text))
                            QuinSecosTextBoxTotal.Text = QuinSecosTextBox.Text;
                        else
                        {
                            val = Convert.ToSingle(QuinSecosTextBoxTotal.Text) + Convert.ToSingle(QuinSecosTextBox.Text);
                            QuinSecosTextBoxTotal.Text = val.ToString();
                        }
                    }
                }
            }
        }

        private void KgBrutoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionPesada(KgBrutoTextBox, KgBrutoTextBoxTotal, "Ej.: 250", e);
        }

        private void CamionLlenoTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionPesada(CamionLlenoTextBox1, CamionLlenoTextBoxTotal, "Ej.: 400", e);
        }

        private void CamionVacioTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionPesada(CamionVacioTextBox1, CamionVacioTextBoxTotal, "Ej.: 250", e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!string.IsNullOrEmpty(CamionLlenoTextBox1.Text) && !CamionLlenoTextBox1.Text.Equals("Ej.: 400"))
                {
                    if (!string.IsNullOrEmpty(CamionVacioTextBox1.Text) && !CamionVacioTextBox1.Text.Equals("Ej.: 250"))
                    {
                        KgBrutoTextBox1.Text = (Convert.ToInt32(CamionLlenoTextBox1.Text) - Convert.ToInt32(CamionVacioTextBox1.Text)).ToString();
                        float val = (Convert.ToSingle(KgBrutoTextBox1.Text) / factor);
                        QuinSecosTextBox1.Text = val.ToString();
                        KgBrutoTextBox1.ReadOnly = true;
                        if (string.IsNullOrEmpty(KgBrutoTextBoxTotal.Text))
                            KgBrutoTextBoxTotal.Text = KgBrutoTextBox1.Text;
                        else
                        {
                            int val1 = Convert.ToInt32(KgBrutoTextBoxTotal.Text) + Convert.ToInt32(KgBrutoTextBox1.Text);
                            KgBrutoTextBoxTotal.Text = val1.ToString();
                        }

                        if (string.IsNullOrEmpty(QuinSecosTextBoxTotal.Text))
                            QuinSecosTextBoxTotal.Text = QuinSecosTextBox1.Text;
                        else
                        {
                            val = Convert.ToSingle(QuinSecosTextBoxTotal.Text) + Convert.ToSingle(QuinSecosTextBox1.Text);
                            QuinSecosTextBoxTotal.Text = val.ToString();
                        }
                    }
                }
            }
        }

        private void KgBrutoTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionPesada(KgBrutoTextBox1, KgBrutoTextBoxTotal, "Ej.: 250", e);
        }

        private void SacosTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionPesada(SacosTextBox2, SacosTextBoxTotal, "Ej.: 1", e);
        }

        private void CamionLlenoTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionPesada(CamionLlenoTextBox2, CamionLlenoTextBoxTotal, "Ej.: 400", e);
        }

        private void CamionVacioTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionPesada(CamionVacioTextBox2, CamionVacioTextBoxTotal, "Ej.: 250", e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!string.IsNullOrEmpty(CamionLlenoTextBox2.Text) && !CamionLlenoTextBox2.Text.Equals("Ej.: 400"))
                {
                    if (!string.IsNullOrEmpty(CamionVacioTextBox2.Text) && !CamionVacioTextBox2.Text.Equals("Ej.: 250"))
                    {
                        KgBrutoTextBox2.Text = (Convert.ToInt32(CamionLlenoTextBox2.Text) - Convert.ToInt32(CamionVacioTextBox2.Text)).ToString();
                        float val = (Convert.ToSingle(KgBrutoTextBox2.Text) / factor);
                        QuinSecosTextBox2.Text = val.ToString();
                        KgBrutoTextBox2.ReadOnly = true;
                        if (string.IsNullOrEmpty(KgBrutoTextBoxTotal.Text))
                            KgBrutoTextBoxTotal.Text = KgBrutoTextBox2.Text;
                        else
                        {
                            int val1 = Convert.ToInt32(KgBrutoTextBoxTotal.Text) + Convert.ToInt32(KgBrutoTextBox2.Text);
                            KgBrutoTextBoxTotal.Text = val1.ToString();
                        }

                        if (string.IsNullOrEmpty(QuinSecosTextBoxTotal.Text))
                            QuinSecosTextBoxTotal.Text = QuinSecosTextBox2.Text;
                        else
                        {
                            val = Convert.ToSingle(QuinSecosTextBoxTotal.Text) + Convert.ToSingle(QuinSecosTextBox2.Text);
                            QuinSecosTextBoxTotal.Text = val.ToString();
                        }
                    }
                }
            }
        }

        private void KgBrutoTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionPesada(KgBrutoTextBox2, KgBrutoTextBoxTotal, "Ej.: 150", e);
        }

        private void SacosTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionPesada(SacosTextBox3, SacosTextBoxTotal, "Ej.: 1", e);
        }

        private void CamionLlenoTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionPesada(CamionLlenoTextBox3, CamionLlenoTextBoxTotal, "Ej.: 400", e);
        }

        private void CamionVacioTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionPesada(CamionVacioTextBox3, CamionVacioTextBoxTotal, "Ej.: 250", e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!string.IsNullOrEmpty(CamionLlenoTextBox3.Text) && !CamionLlenoTextBox3.Text.Equals("Ej.: 400"))
                {
                    if (!string.IsNullOrEmpty(CamionVacioTextBox3.Text) && !CamionVacioTextBox3.Text.Equals("Ej.: 250"))
                    {
                        KgBrutoTextBox3.Text = (Convert.ToInt32(CamionLlenoTextBox3.Text) - Convert.ToInt32(CamionVacioTextBox3.Text)).ToString();
                        float val = (Convert.ToSingle(KgBrutoTextBox3.Text) / factor);
                        QuinSecosTextBox3.Text = val.ToString();
                        KgBrutoTextBox3.ReadOnly = true;
                        if (string.IsNullOrEmpty(KgBrutoTextBoxTotal.Text))
                            KgBrutoTextBoxTotal.Text = KgBrutoTextBox3.Text;
                        else
                        {
                            int val1 = Convert.ToInt32(KgBrutoTextBoxTotal.Text) + Convert.ToInt32(KgBrutoTextBox3.Text);
                            KgBrutoTextBoxTotal.Text = val1.ToString();
                        }

                        if (string.IsNullOrEmpty(QuinSecosTextBoxTotal.Text))
                            QuinSecosTextBoxTotal.Text = QuinSecosTextBox3.Text;
                        else
                        {
                            val = Convert.ToSingle(QuinSecosTextBoxTotal.Text) + Convert.ToSingle(QuinSecosTextBox3.Text);
                            QuinSecosTextBoxTotal.Text = val.ToString();
                        }
                    }
                }
            }
        }

        private void KgBrutoTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionPesada(KgBrutoTextBox3, KgBrutoTextBoxTotal, "Ej.: 150", e);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(NumeroComprobanteTextBox.Text) && !NumeroComprobanteTextBox.Text.Equals("Ejemplo: 001"))
            {
                var Comprobante = BLL.ComprobaanteRecepcionCacaosBLL.Buscar(Convert.ToInt32(NumeroComprobanteTextBox.Text));
                if(Comprobante != null)
                {
                    FechaDateTimePicker.Value = Comprobante.Fecha;
                    AsociacionTextBox.Text = Comprobante.Asociacion;
                    ProductorIdTextBox.Text = Comprobante.ProductorId.ToString();
                    ProductorComboBox.SelectedItem = Comprobante.NombreProductor;
                    CedulaMaskedTextBox.Text = Comprobante.CedulaProductor.ToString();
                    TipoProductoComboBox.SelectedItem = Comprobante.TipoProducto;
                    CertificacionProductoComboBox.SelectedItem = Comprobante.CertificacionProducto;
                    EstadoProductoComboBox.SelectedItem = Comprobante.EstadoProducto;
                    SacosTextBoxTotal.Text = Comprobante.Sacos.ToString();
                    CamionLlenoTextBoxTotal.Text = Comprobante.CamionLleno.ToString();
                    CamionVacioTextBoxTotal.Text = Comprobante.CamionVacio.ToString();
                    FactorTextBoxTotal.Text = Comprobante.FactorConversion.ToString();
                    QuinSecosTextBoxTotal.Text = Comprobante.Quintales.ToString();
                    HumedadTextBox.Text = Comprobante.DescuentoHumedad.ToString();
                    BasuraTextBox.Text = Comprobante.DescuentoBasura.ToString();
                    MohoTextBox.Text = Comprobante.DescuentoMoho.ToString();
                    ChoferTextBox.Text = Comprobante.NombreChofer;
                    TipoTransporteTextBox.Text = Comprobante.NombreChofer;
                    PlacaTextBox.Text = Comprobante.PlacaVehiculo;
                    ZonaTextBox.Text = Comprobante.ZonaProcedencia;
                    SacosTextBox.ReadOnly = SacosTextBox1.ReadOnly = SacosTextBox2.ReadOnly = SacosTextBox3.ReadOnly = true;
                    CamionLlenoTextBox.ReadOnly = CamionLlenoTextBox1.ReadOnly = CamionLlenoTextBox2.ReadOnly = CamionLlenoTextBox3.ReadOnly = true;
                    CamionVacioTextBox.ReadOnly = CamionVacioTextBox1.ReadOnly = CamionVacioTextBox2.ReadOnly = CamionVacioTextBox3.ReadOnly = true;
                    KgBrutoTextBox.ReadOnly = KgBrutoTextBox1.ReadOnly = KgBrutoTextBox2.ReadOnly = KgBrutoTextBox3.ReadOnly = true;

                }
                else
                {
                    MessageBox.Show("El Comprobante no existe");
                }
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NumeroComprobanteTextBox.Text))
            {
                if (!string.IsNullOrEmpty(ProductorIdTextBox.Text))
                {
                    if (CedulaMaskedTextBox.MaskFull)
                    {
                        if (!string.IsNullOrEmpty(SacosTextBoxTotal.Text))
                        {
                            if (!string.IsNullOrEmpty(KgBrutoTextBoxTotal.Text))
                            {
                                if (!string.IsNullOrEmpty(FactorTextBoxTotal.Text))
                                {
                                    if (!string.IsNullOrEmpty(TipoTransporteTextBox.Text))
                                    {
                                        if (!string.IsNullOrEmpty(ChoferTextBox.Text))
                                        {
                                            if (!string.IsNullOrEmpty(ZonaTextBox.Text))
                                            {
                                                var Ced = CedulaMaskedTextBox.Text.Split('-');
                                                var cdula = Ced[0] + Ced[1] + Ced[2];
                                                var Comprobante = new ComprobanteRecepcionCacaos();
                                                Comprobante.NumeroComprobante = Convert.ToInt32(NumeroComprobanteTextBox.Text);
                                                Comprobante.Fecha = FechaDateTimePicker.Value;
                                                if (!string.IsNullOrEmpty(AsociacionTextBox.Text))
                                                    Comprobante.Asociacion = AsociacionTextBox.Text;
                                                Comprobante.ProductorId = Convert.ToInt32(ProductorIdTextBox.Text);
                                                Comprobante.NombreProductor = ProductorComboBox.SelectedItem.ToString();
                                                Comprobante.CedulaProductor = Convert.ToInt64(cdula);
                                                Comprobante.TipoProducto = TipoProductoComboBox.SelectedItem.ToString();
                                                Comprobante.CertificacionProducto = CertificacionProductoComboBox.SelectedItem.ToString();
                                                Comprobante.EstadoProducto = EstadoProductoComboBox.SelectedItem.ToString();
                                                Comprobante.Sacos = Convert.ToInt32(SacosTextBoxTotal.Text);
                                                if (!string.IsNullOrEmpty(CamionLlenoTextBoxTotal.Text))
                                                    Comprobante.CamionLleno = Convert.ToInt64(CamionLlenoTextBoxTotal.Text);
                                                if (!string.IsNullOrEmpty(CamionVacioTextBoxTotal.Text))
                                                    Comprobante.CamionVacio = Convert.ToInt64(CamionVacioTextBoxTotal.Text);
                                                Comprobante.KgBruto = Convert.ToDecimal(KgBrutoTextBoxTotal.Text);
                                                Comprobante.FactorConversion = Convert.ToDecimal(FactorTextBoxTotal.Text);
                                                Comprobante.Quintales = Convert.ToDecimal(QuinSecosTextBoxTotal.Text);
                                                if (!string.IsNullOrEmpty(HumedadTextBox.Text) && !HumedadTextBox.Text.Equals("Ej.: 2"))
                                                    Comprobante.DescuentoHumedad = Convert.ToInt32(HumedadTextBox.Text);
                                                if (!string.IsNullOrEmpty(BasuraTextBox.Text) && !BasuraTextBox.Text.Equals("Ej.: 3"))
                                                    Comprobante.DescuentoBasura = Convert.ToInt32(BasuraTextBox.Text);
                                                if (!string.IsNullOrEmpty(MohoTextBox.Text) && !MohoTextBox.Text.Equals("Ej.: 4"))
                                                    Comprobante.DescuentoMoho = Convert.ToInt32(MohoTextBox.Text);
                                                Comprobante.NombreChofer = ChoferTextBox.Text;
                                                Comprobante.TipoTransporte = TipoTransporteTextBox.Text;
                                                Comprobante.ZonaProcedencia = ZonaTextBox.Text;
                                                if (!string.IsNullOrEmpty(PlacaTextBox.Text))
                                                    Comprobante.PlacaVehiculo = PlacaTextBox.Text;
                                                Comprobante.RecibidoPor = "Santiago Perez";
                                                Comprobante.EntregadoPor = ChoferTextBox.Text;
                                                BLL.ComprobaanteRecepcionCacaosBLL.Eliminar(Comprobante);
                                            }
                                            else { }
                                        }
                                        else
                                        {

                                        }
                                    }
                                    else { }
                                }
                                else { }
                            }
                            else
                            { }
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
    }
}
