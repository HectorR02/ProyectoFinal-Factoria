using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class TiposEmpleados
    {
        [Key]
        public int TipoEmpleadoId { get; set; }

        public string TipoEmpleado { get; set; }

        public TiposEmpleados(string tipoEmpleado)
        {
            this.TipoEmpleado = tipoEmpleado;
        }

        public TiposEmpleados()
        {

        }
    }
}
