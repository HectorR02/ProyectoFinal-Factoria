using System;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class RecibosRecepcionProductos
    {
        [Key]
        public int NumeroRecibo { get; set; }

        public DateTime Fecha { get; set; }

        public string NombreProductor { get; set; }

        public Int64 CedulaProductor { get; set; }

        public string AsociacionProductor { get; set; }

        public string Detalle { get; set; }

        public int PorcientoSaco { get; set; }

        public int PorcientoMoho { get; set; }

        public int PorcientoImpureza { get; set; }

        public int PorcientoHumedad { get; set; }

        public Decimal TotalTara { get; set; }

        public Decimal DescuentoSacos { get; set; }

        public Decimal DescuentoMoho { get; set; }

        public Decimal DescuentoImpureza { get; set; }

        public Decimal DescuentoHumedad { get; set; }

        public DateTime FechaRecepcion { get; set; }

        public string Apagar { get; set; }

        public string Notas { get; set; }

        public string RecibidoPor { get; set; }

        public string RealizadoPor { get; set; }

        public int ProductorId { get; set; }

        public int FactoriaRNC { get; set; }
    }
}
