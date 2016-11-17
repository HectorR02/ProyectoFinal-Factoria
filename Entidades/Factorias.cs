using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Factorias
    {
        [Key]
        public int FactoriaRNC { get; set; }

        public string NombreSucursal { get; set; }

        public string Direccion { get; set; }

        public int Telefono { get; set; }

        public Factorias(int rnc, string nombreSucursal, string direccion, int telf)
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
