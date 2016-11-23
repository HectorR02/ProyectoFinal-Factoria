using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class TipoProductos
    {
        [Key]
        public int TipoId { get; set; }

        public string Tipo { get; set; }

        public TipoProductos(string tipo)
        {
            this.Tipo = tipo;
        }

        public TipoProductos()
        {

        }
    }
}
