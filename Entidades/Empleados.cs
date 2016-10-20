using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Empleados
    {
        [Key]
        public int EmpleadoId { get; set; }

        public string Nombres { get; set; }

        public int Cedula { get; set; }

        public string Direccion { get; set; }

        public int Telefono { get; set; }

        public string TipoEmpleado { get; set; }

        public int FactoriaRNC { get; set; }
    }
}
