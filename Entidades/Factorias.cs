using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Factorias
    {
        [Key]
        public int RNC { get; set; }

        public string NombreSucursal { get; set; }

        public string Direccion { get; set; }

        public int Telefono { get; set; }
    }
}
