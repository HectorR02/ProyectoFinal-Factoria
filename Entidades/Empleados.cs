using System;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Empleados
    {
        [Key]
        public int EmpleadoId { get; set; }

        public string Nombres { get; set; }

        public Int64 Cedula { get; set; }

        public string Direccion { get; set; }

        public Int64 Telefono { get; set; }

        public string TipoEmpleado { get; set; }

        public int FactoriaRNC { get; set; }
    }
}
