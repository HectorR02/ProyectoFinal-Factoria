using System;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class ComprobanteRecepcionCacaos
    {
        [Key]
        public int NumeroComprobante { get; set; }

        public DateTime Fecha { get; set; }

        public string  Asociacion { get; set; }

        public string NombreProductor { get; set; }

        public Int64 CedulaProductor { get; set; }

        public string TipoProducto { get; set; }

        public string EstadoProducto { get; set; }

        public string CertificacionProducto { get; set; }

        public int DescuentoMoho { get; set; }

        public int DescuentoBasura { get; set; }

        public int DescuentoHumedad { get; set; }

        public string NombreChofer { get; set; }

        public string TipoTransporte { get; set; }

        public string PlacaVehiculo { get; set; }

        public string ZonaProcedencia { get; set; }

        public string RecibidoPor { get; set; }

        public string EntregadoPor { get; set; }

        public int ProductorId { get; set; }

        public Double TotalQuintales { get; set; }

        public ComprobanteRecepcionCacaos(DateTime fecha, string asoc, string productor, Int64 cedulaProd, string tipoProd,
            string estadoProd, string certificacion, int descMoho, int descBas, int descHum, string chofer, string tipTrans, 
            string placa, string zona, string recibidoX, string entregadoX, int productorId)
        {
            this.Fecha = fecha;
            this.Asociacion = asoc;
            this.NombreProductor = productor;
            this.CedulaProductor = cedulaProd;
            this.TipoProducto = tipoProd;
            this.EstadoProducto = estadoProd;
            this.CertificacionProducto = certificacion;
            this.DescuentoMoho = descMoho;
            this.DescuentoBasura = descBas;
            this.DescuentoHumedad = descHum;
            this.NombreChofer = chofer;
            this.TipoTransporte = tipTrans;
            this.PlacaVehiculo = placa;
            this.ZonaProcedencia = zona;
            this.RecibidoPor = recibidoX;
            this.EntregadoPor = entregadoX;
            this.ProductorId = productorId;
            this.TotalQuintales = 0.0;
        }

        public ComprobanteRecepcionCacaos()
        {

        }
    }
}
