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
            

            NumeroComprobanteTextBox.Focus();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
           
        }       

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(NumeroComprobanteTextBox.Text) && !NumeroComprobanteTextBox.Text.Equals("Ejemplo: 001"))
            {
                var Comprobante = BLL.ComprobaanteRecepcionCacaosBLL.Buscar(Convert.ToInt32(NumeroComprobanteTextBox.Text));
                if(Comprobante != null)
                {
                    
                }
                else
                {
                    MessageBox.Show("El Comprobante no existe");
                }
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
