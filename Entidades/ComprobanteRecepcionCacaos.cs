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

        public int CedulaProductor { get; set; }

        public string TipoProducto { get; set; }

        public string EstadoProducto { get; set; }

        public string CertificacionProducto { get; set; }

        public double KgBruto { get; set; }

        public double Quintales { get; set; }

        public float FactorConversion { get; set; }

        public int Sacos { get; set; }

        public float DescuentoMoho { get; set; }

        public float DescuentoBasura { get; set; }

        public float DescuentoHumedad { get; set; }

        public string NombreChofer { get; set; }

        public string TipoTransporte { get; set; }

        public string PlacaVehiculo { get; set; }

        public string ZonaProcedencia { get; set; }

        public string RecibidoPor { get; set; }

        public string EntregadoPor { get; set; }

        public int CedulaChofer { get; set; }

        public int ProductorId { get; set; }
    }
}
