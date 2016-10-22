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

        public Decimal KgBruto { get; set; }

        public Decimal Quintales { get; set; }

        public Decimal FactorConversion { get; set; }

        public int Sacos { get; set; }

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

        public Int64 CamionLleno { get; set; }

        public Int64 CamionVacio { get; set; }
    }
}
