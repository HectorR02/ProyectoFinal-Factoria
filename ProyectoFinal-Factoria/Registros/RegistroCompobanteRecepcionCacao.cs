using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoFinal_Factoria.Registros
{
    public partial class RegistroCompobanteRecepcionCacao : Form
    {
        private List<Pesadas> pesadas;
        public RegistroCompobanteRecepcionCacao()
        {
            InitializeComponent();

            Validaciones();
            CargarTipoProducto();
            CargarCertificacionProd();
            CargarEstadoProd();
            LimpiarCampos();
            CargarProductores();
            pesadas = new List<Pesadas>();
        }
        
        private void CargarProductores()
        {
            while (true)
            {
                List<Productores> lista = BLL.ProductoresBLL.GetList();
                if (lista.Count <= 0)
                {
                    MessageBox.Show("No hay productores registrados debes registrar alguno\nantes de seguir con este proceso", "-- Aviso --", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    var ventana = new RegistroProductor();
                    ventana.ShowDialog();
                }
                else
                {
                    ProductorComboBox.ValueMember = "ProductorId";
                    ProductorComboBox.DisplayMember = "Nombres";
                    ProductorComboBox.DataSource = lista;
                    break;
                }
            }
        }

        private void CargarTipoProducto()
        {
            var lista = BLL.TipoProductosBLL.GetList();

            if (lista.Count <= 0)
            {
                var tp = new TipoProductos("Sánchez");
                var tp1 = new TipoProductos("Hispaniola");

                BLL.TipoProductosBLL.Insertar(tp);
                BLL.TipoProductosBLL.Insertar(tp1);

                lista = BLL.TipoProductosBLL.GetList();
            }

            TipoProductoComboBox.DataSource = lista;
            TipoProductoComboBox.ValueMember = "TipoId";
            TipoProductoComboBox.DisplayMember = "Tipo";
        }

        private void CargarCertificacionProd()
        {
            var lista = BLL.CertificacionProductosBLL.GetList();

            if (lista.Count <= 0)
            {
                var CCFP = new CertificacionProductos(0, "Ninguna");
                var CCFP5 = new CertificacionProductos(0, "Orgánico");
                var CCFP1 = new CertificacionProductos(0, "Rain Forest");
                var CCFP2 = new CertificacionProductos(0, "UTZ");
                var CCFP3 = new CertificacionProductos(0, "FLO");
                var CCFP4 = new CertificacionProductos(0, "Convencional");

                BLL.CertificacionProductosBLL.Insertar(CCFP);
                BLL.CertificacionProductosBLL.Insertar(CCFP1);
                BLL.CertificacionProductosBLL.Insertar(CCFP2);
                BLL.CertificacionProductosBLL.Insertar(CCFP3);
                BLL.CertificacionProductosBLL.Insertar(CCFP4);
                BLL.CertificacionProductosBLL.Insertar(CCFP5);

                lista = BLL.CertificacionProductosBLL.GetList();
            }

            CertificacionProductoComboBox.DataSource = lista;
            CertificacionProductoComboBox.ValueMember = "CertificacionId";
            CertificacionProductoComboBox.DisplayMember = "Certificacion";
        }

        private void CargarEstadoProd()
        {
            var lista = BLL.EstadoProductosBLL.GetList();

            if (lista.Count <= 0)
            {
                var CEP = new EstadoProductos("Baba");
                var CEP1 = new EstadoProductos("Fermentado");
                var CEP2 = new EstadoProductos("Seco");
                var CEP3 = new EstadoProductos("Con Gomo");
                var CEP4 = new EstadoProductos("Oreado");

                BLL.EstadoProductosBLL.Insertar(CEP);
                BLL.EstadoProductosBLL.Insertar(CEP1);
                BLL.EstadoProductosBLL.Insertar(CEP2);
                BLL.EstadoProductosBLL.Insertar(CEP3);
                BLL.EstadoProductosBLL.Insertar(CEP4);

                lista = BLL.EstadoProductosBLL.GetList();
            }

            EstadoProductoComboBox.DataSource = lista;
            EstadoProductoComboBox.ValueMember = "EstadoId";
            EstadoProductoComboBox.DisplayMember = "Estado";
        }

        private void Validaciones()
        {
            var val = new Utileria(NumeroComprobanteTextBox, "Ejemplo: 001", AsociacionTextBox, "N");
            var val1 = new Utileria(AsociacionTextBox, "Ejemplo: Productores Independientes", ProductorIdTextBox, "LN");
            var val2 = new Utileria(ProductorIdTextBox, "Ejemplo: 001", CedulaMaskedTextBox, "N");


            var val31 = new Utileria(HumedadTextBox, "Ej.: 2", BasuraTextBox, "N");
            var val32 = new Utileria(BasuraTextBox, "Ej.: 3", MohoTextBox, "N");
            var val33 = new Utileria(MohoTextBox, "Ej.: 4", ChoferTextBox, "N");
        }
        
        private void RegistroCompobanteRecepcionCacao_Load(object sender, EventArgs e)
        {

        }

        private void LimpiarCampos()
        {
            int id = BLL.ComprobaanteRecepcionCacaosBLL.Identity();
            NumeroComprobanteTextBox.Clear();
            FechaDateTimePicker.Value = DateTime.Today;
            AsociacionTextBox.Clear();
            ProductorIdTextBox.Clear();
            //ProductorComboBox.SelectedIndex = 0;
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
            SacostextBox1.Clear();
            CamionLlenotextBox2.Clear();
            CamionVaciotextBox3.Clear();
            KgBrutotextBox4.Clear();
            FactorConversiontextBox5.Clear();
            QuintalesSecostextBox.Clear();
            pesadas = new List<Pesadas>();
            PesadasdataGridView1.DataSource = null;
            if (id > 1 || BLL.ComprobaanteRecepcionCacaosBLL.GetList().Count > 0)
                NumeroComprobanteTextBox.Text = (id + 1).ToString();
            else
                NumeroComprobanteTextBox.Text = id.ToString();
            AsociacionTextBox.Focus();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private int ToInt(string texto)
        {
            int entero;
            int.TryParse(texto, out entero);
            return entero;
        }

        private ComprobanteRecepcionCacaos LlenarCampos()
        {
            var Ced = CedulaMaskedTextBox.Text.Split('-');
            var cdula = Ced[0] + Ced[1] + Ced[2];

            ComprobanteRecepcionCacaos nuevo = new ComprobanteRecepcionCacaos();

            nuevo.Fecha = FechaDateTimePicker.Value;
            nuevo.Asociacion = AsociacionTextBox.Text;
            nuevo.NombreProductor = ProductorComboBox.Text;
            nuevo.CedulaProductor = Convert.ToInt64(cdula);
            nuevo.TipoProducto = TipoProductoComboBox.Text;
            nuevo.EstadoProducto = EstadoProductoComboBox.Text;
            nuevo.CertificacionProducto = CertificacionProductoComboBox.Text;
            nuevo.DescuentoMoho = ToInt(MohoTextBox.Text);
            nuevo.DescuentoBasura = ToInt(BasuraTextBox.Text);
            nuevo.DescuentoHumedad = ToInt(HumedadTextBox.Text);
            nuevo.NombreChofer = ChoferTextBox.Text;
            nuevo.TipoTransporte = TipoTransporteTextBox.Text;
            nuevo.PlacaVehiculo = PlacaTextBox.Text;
            nuevo.ZonaProcedencia = ZonaTextBox.Text;
            nuevo.RecibidoPor = "Juan";
            nuevo.EntregadoPor = "Pedro";
            nuevo.ProductorId = ToInt(ProductorIdTextBox.Text);
            Double totalQuintales = 0;
            foreach (var pesada in pesadas)
                totalQuintales += pesada.QuinSecos;
            nuevo.TotalQuintales = totalQuintales;
            return nuevo;
        }

        private void LlenarCampos(ComprobanteRecepcionCacaos comprobante)
        {
            NumeroComprobanteTextBox.Text = comprobante.NumeroComprobante.ToString();
            AsociacionTextBox.Text = comprobante.Asociacion;
            ProductorIdTextBox.Text = comprobante.ProductorId.ToString();
            ProductorComboBox.SelectedText = comprobante.NombreProductor;
            CedulaMaskedTextBox.Text = comprobante.CedulaProductor.ToString();
            TipoProductoComboBox.Text = comprobante.TipoProducto;
            CertificacionProductoComboBox.Text = comprobante.CertificacionProducto;
            EstadoProductoComboBox.Text = comprobante.EstadoProducto;
            HumedadTextBox.Text = comprobante.DescuentoHumedad.ToString();
            BasuraTextBox.Text = comprobante.DescuentoBasura.ToString();
            MohoTextBox.Text = comprobante.DescuentoMoho.ToString();
            ChoferTextBox.Text = comprobante.NombreChofer;
            PlacaTextBox.Text = comprobante.PlacaVehiculo;
            ZonaTextBox.Text = comprobante.ZonaProcedencia;
            TipoTransporteTextBox.Text = comprobante.TipoTransporte;
        }

        private bool CamposLlenos()
        {
            bool resultado = false;
            if (!string.IsNullOrEmpty(NumeroComprobanteTextBox.Text))
                if (!string.IsNullOrEmpty(ProductorIdTextBox.Text))
                    if (!string.IsNullOrEmpty(ProductorComboBox.Text))
                        if (CedulaMaskedTextBox.MaskFull)
                            if (!string.IsNullOrEmpty(TipoProductoComboBox.Text))
                                if (!string.IsNullOrEmpty(CertificacionProductoComboBox.Text))
                                    if (!string.IsNullOrEmpty(EstadoProductoComboBox.Text))
                                        if (pesadas.Count > 0)
                                            if (!string.IsNullOrEmpty(ChoferTextBox.Text))
                                                if (!string.IsNullOrEmpty(PlacaTextBox.Text))
                                                    if (!string.IsNullOrEmpty(ZonaTextBox.Text))
                                                        if (!string.IsNullOrEmpty(TipoTransporteTextBox.Text))
                                                            resultado = true;
            return resultado;
        }

        private void ConfirmarPesadas()
        {
            foreach (var pesada in pesadas)
                pesada.ComprobanteId = BLL.ComprobaanteRecepcionCacaosBLL.Identity();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (CamposLlenos())
            {
                if (BLL.ComprobaanteRecepcionCacaosBLL.Insertar(LlenarCampos()))
                {
                    ConfirmarPesadas();
                    BLL.PesadasBLL.Insertar(pesadas);
                }
                LimpiarCampos();
            }
            else
                MessageBox.Show("No Puede Dejar Ningun Campo Vacío", "-- Aviso --", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NumeroComprobanteTextBox.Text) && !NumeroComprobanteTextBox.Text.Equals("Ejemplo: 001"))
            {
                var Comprobante = BLL.ComprobaanteRecepcionCacaosBLL.Buscar(ToInt(NumeroComprobanteTextBox.Text));
                if (Comprobante != null)
                {
                    LlenarCampos(Comprobante);
                    PesadasdataGridView1.DataSource = null;
                    PesadasdataGridView1.DataSource = BLL.PesadasBLL.GetList(ToInt(NumeroComprobanteTextBox.Text));
                }
                else
                {
                    MessageBox.Show("El Comprobante no existe", "-- Aviso --", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (BLL.ComprobaanteRecepcionCacaosBLL.Buscar(ToInt(NumeroComprobanteTextBox.Text)) != null)
            {
                if (BLL.ComprobaanteRecepcionCacaosBLL.Eliminar(BLL.ComprobaanteRecepcionCacaosBLL.Buscar(ToInt(NumeroComprobanteTextBox.Text))))
                    BLL.PesadasBLL.Eliminar(ToInt(NumeroComprobanteTextBox.Text));
            }
            else
                MessageBox.Show("No se pudo eliminar el registro solicitado", "-- Transaccion Fallida --", MessageBoxButtons.OK, MessageBoxIcon.Error);
            LimpiarCampos();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private Double ToDouble(string texto)
        {
            Double numero;
            Double.TryParse(texto, out numero);
            return numero;
        }

        private Pesadas LlenarPesada()
        {
            Pesadas pesada = new Pesadas();
            pesada.ComprobanteId = BLL.ComprobaanteRecepcionCacaosBLL.Identity() + 1;
            pesada.Sacos = ToInt(SacostextBox1.Text);
            pesada.CamionLleno = ToInt(CamionLlenotextBox2.Text);
            pesada.CamionVacio = ToInt(CamionVaciotextBox3.Text);
            pesada.KgBruto = ToInt(KgBrutotextBox4.Text);
            pesada.Convercion = ToInt(FactorConversiontextBox5.Text);
            pesada.QuinSecos = ToDouble(QuintalesSecostextBox.Text);
            return pesada;
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SacostextBox1.Text))
            {
                if (!string.IsNullOrEmpty(CamionLlenotextBox2.Text))
                {
                    if (!string.IsNullOrEmpty(CamionVaciotextBox3.Text))
                    {
                        if (!string.IsNullOrEmpty(KgBrutotextBox4.Text))
                        {
                            if (!string.IsNullOrEmpty(FactorConversiontextBox5.Text))
                            {
                                if (!string.IsNullOrEmpty(QuintalesSecostextBox.Text))
                                {
                                    int noComprobante = BLL.ComprobaanteRecepcionCacaosBLL.Identity();
                                    pesadas.Add(LlenarPesada());
                                    PesadasdataGridView1.DataSource = null;
                                    PesadasdataGridView1.DataSource = pesadas;
                                }
                                else { }
                            }
                            else { }
                        }
                        else { }
                    }
                    else { }
                }
                else { }
            }
            else { }
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            var reporte = new VentanasReportes.ReporteComprobanteRecepcionCacao();
            reporte.NumeroComprobante = ToInt(NumeroComprobanteTextBox.Text);
            reporte.Show();
        }

        private void ProductorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var productor = BLL.ProductoresBLL.Buscar((int)ProductorComboBox.SelectedValue);
            if(productor != null)
            {
                AsociacionTextBox.Text = productor.Asociacion;
                ProductorIdTextBox.Text = productor.ProductorId.ToString();
                CedulaMaskedTextBox.Text = productor.Cedula.ToString();
            }
        }
    }
}
