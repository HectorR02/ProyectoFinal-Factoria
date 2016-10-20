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

        public int CedulaProductor { get; set; }

        public string AsociacionProductor { get; set; }

        public string Detalle { get; set; }

        public int PorcientoSaco { get; set; }

        public int PorcientoMoho { get; set; }

        public int PorcientoImpureza { get; set; }

        public int PorcientoHumedad { get; set; }

        public double TotalTara { get; set; }

        public float DescuentoSacos { get; set; }

        public float DescuentoMoho { get; set; }

        public float DescuentoImpureza { get; set; }

        public float DescuentoHumedad { get; set; }

        public DateTime FechaRecepcion { get; set; }

        public string Apagar { get; set; }

        public string Notas { get; set; }

        public string RecibidoPor { get; set; }

        public string RealizadoPor { get; set; }

        public int ProductorId { get; set; }

        public int FactoriaRNC { get; set; }
    }
}
