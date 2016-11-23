using System;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Factorias
    {
        [Key]
        public int FactoriaId { get; set; }

        public int FactoriaRNC { get; set; }

        public string NombreSucursal { get; set; }

        public string Direccion { get; set; }

        public Int64 Telefono { get; set; }

        public Factorias(int rnc, string nombreSucursal, string direccion, Int64 telf)
        {
            this.FactoriaRNC = rnc;
            this.NombreSucursal = nombreSucursal;
            this.Direccion = direccion;
            this.Telefono = telf;
        }

        public Factorias()
        {
        }
    }
}
