using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class TiposDeUsuarios
    {
        [Key]
        public int TipoUsuarioId { get; set; }

        public string Nombre { get; set; }

        public TiposDeUsuarios(int id, string nombre)
        {
            TipoUsuarioId = id;
            Nombre = nombre;
        }

        public TiposDeUsuarios(string nombre)
        {
            this.Nombre = nombre;
        }

        public TiposDeUsuarios()
        {
        }
    }
}
