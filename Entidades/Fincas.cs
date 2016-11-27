using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Fincas
    {
        [Key]
        public int FincaId { get; set; }

        public int NumeroParcela { get; set; }

        public string Sector { get; set; }

        public string Propietario { get; set; }

        public int ProductorId { get; set; }

        public Fincas(int productorId, int numeroParcela, string sector, string propietario)
        {
            this.NumeroParcela = numeroParcela;
            this.Sector = sector;
            this.Propietario = propietario;
            this.ProductorId = productorId;
        }

        public Fincas()
        {
        }
    }
}
