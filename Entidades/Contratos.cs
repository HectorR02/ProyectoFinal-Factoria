﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Contratos
    {
        [Key]
        public int NumeroContrato { get; set; }

        public DateTime FechaEmision { get; set; }

        public string Detalle { get; set; }

        public string NombreProductor { get; set; }

        public int CedulaProductor { get; set; }

        public int Quintales { get; set; }

        public int PrecioPorQuintal { get; set; }

        public string FirmaAutorizada { get; set; }

        public int ProductorId { get; set; }

        public int FactoriaRNC { get; set; }
    }
}