using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class EstadoProductos
    {
        [Key]
        public int EstadoId { get; set; }

        public string Estado { get; set; }

        public EstadoProductos(string estado)
        {
            this.Estado = estado;
        }

        public EstadoProductos()
        {

        }
    }
}
