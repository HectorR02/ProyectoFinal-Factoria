using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Fincas
    {
        [Key]
        public int NumeroParcela { get; set; }

        public string Sector { get; set; }

        public string Propietario { get; set; }

        public int ProductorId { get; set; }
    }
}
