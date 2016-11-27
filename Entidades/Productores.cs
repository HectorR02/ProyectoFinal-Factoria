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

        public string Asociacion { get; set; }

        public Productores()
        {

        }

        public Productores(string nombre, Int64 cedula, int rnc, string asociacion)
        {
            this.Nombres = nombre;
            this.Cedula = cedula;
            this.FactoriaRNC = rnc;
            this.Asociacion = asociacion;
        }
    }
}
