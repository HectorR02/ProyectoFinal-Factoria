using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Contratos
    {
        [Key] [Browsable(false)]
        public int NumeroContrato { get; set; }

        public DateTime FechaEmision { get; set; }

        [Browsable(false)]
        public string Detalle { get; set; }

        public string NombreProductor { get; set; }

        public Int64 CedulaProductor { get; set; }

        public int Quintales { get; set; }

        public Double PrecioPorQuintal { get; set; }

        public string FirmaAutorizada { get; set; }

        [Browsable(false)]
        public int ProductorId { get; set; }

        public Int64 FactoriaRNC { get; set; }

        public Contratos()
        {

        }
    }
}
