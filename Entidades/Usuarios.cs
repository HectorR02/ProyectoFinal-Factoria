using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }

        public string Nombre { get; set; }

        public string Contraseña { get; set; }

        public int TipoUsuarioId { get; set; }

        public Usuarios(int usuarioId, string nombre, string contraseña, int tipoUsuarioId)
        {
            this.UsuarioId = usuarioId;
            this.Nombre = nombre;
            this.Contraseña = contraseña;
            this.TipoUsuarioId = tipoUsuarioId;
        }

        public Usuarios()
        {
        }
    }
}
