using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Productores
    {
        [Key]
        public int ProductorId { get; set; }

        public string Nombre { get; set; }

        public int Cedula { get; set; }

        public int FactoriaRNC { get; set; }
    }
}
