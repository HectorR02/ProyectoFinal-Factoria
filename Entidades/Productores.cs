using System;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Productores
    {
        [Key]
        public int ProductorId { get; set; }

        public string Nombres { get; set; }

        public Int64 Cedula { get; set; }

        public int FactoriaRNC { get; set; }
    }
}
