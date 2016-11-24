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

        //Permisos especificacion - [R = Registro, C = Consulta.]
        public int RCertificacion { get; set; }

        public int RComprobante { get; set; }

        public int RContrato { get; set; }

        public int REmpleado { get; set; }

        public int REstadoProducto { get; set; }

        public int RFactoria { get; set; }

        public int RFinca { get; set; }

        public int RPesada { get; set; }

        public int RProductores { get; set; }

        public int RReciboRecepcion { get; set; }

        public int RTipoProducto { get; set; }

        public int RTipoUsuario { get; set; }

        public int RTipoEmpleado { get; set; }

        public int RUsuario { get; set; }

        public int CCertificacion { get; set; }

        public int CComprobante { get; set; }

        public int CContrato { get; set; }

        public int CEmpleado { get; set; }

        public int CEstadoProducto { get; set; }

        public int CFactoria { get; set; }

        public int CFinca { get; set; }

        public int CPesada { get; set; }

        public int CProductores { get; set; }

        public int CReciboRecepcion { get; set; }

        public int CTipoProducto { get; set; }

        public int CTipoUsuario { get; set; }

        public int CTipoEmpleado { get; set; }

        public int CUsuario { get; set; }

        public Usuarios(int usuarioId, string nombre, string contraseña, int tipoUsuarioId)
        {
            this.UsuarioId = usuarioId;
            this.Nombre = nombre;
            this.Contraseña = contraseña;
            this.TipoUsuarioId = tipoUsuarioId;
            this.RCertificacion = 0;
            this.RComprobante = 0;
            this.RContrato = 0;
            this.REmpleado = 0;
            this.REstadoProducto = 0;
            this.RFactoria = 0;
            this.RFinca = 0;
            this.RPesada = 0;
            this.RProductores = 0;
            this.RReciboRecepcion = 0;
            this.RTipoProducto = 0;
            this.RTipoUsuario = 0;
            this.RTipoEmpleado = 0;
            this.RUsuario = 0;
            this.CCertificacion = 0;
            this.CComprobante = 0;
            this.CContrato = 0;
            this.CEmpleado = 0;
            this.CEstadoProducto = 0;
            this.CFactoria = 0;
            this.CFinca = 0;
            this.CPesada = 0;
            this.CProductores = 0;
            this.CReciboRecepcion = 0;
            this.CTipoProducto = 0;
            this.CTipoUsuario = 0;
            this.CTipoEmpleado = 0;
            this.CUsuario = 0;
        }
        public Usuarios()
        {
            this.RCertificacion = 0;
            this.RComprobante = 0;
            this.RContrato = 0;
            this.REmpleado = 0;
            this.REstadoProducto = 0;
            this.RFactoria = 0;
            this.RFinca = 0;
            this.RPesada = 0;
            this.RProductores = 0;
            this.RReciboRecepcion = 0;
            this.RTipoProducto = 0;
            this.RTipoUsuario = 0;
            this.RTipoEmpleado = 0;
            this.RUsuario = 0;
            this.CCertificacion = 0;
            this.CComprobante = 0;
            this.CContrato = 0;
            this.CEmpleado = 0;
            this.CEstadoProducto = 0;
            this.CFactoria = 0;
            this.CFinca = 0;
            this.CPesada = 0;
            this.CProductores = 0;
            this.CReciboRecepcion = 0;
            this.CTipoProducto = 0;
            this.CTipoUsuario = 0;
            this.CTipoEmpleado = 0;
            this.CUsuario = 0;
        }
        public Usuarios(string nombre, string contraseña, int tipoUsuarioId)
        {
            this.Nombre = nombre;
            this.Contraseña = contraseña;
            this.TipoUsuarioId = tipoUsuarioId;
            this.RCertificacion = 0;
            this.RComprobante = 0;
            this.RContrato = 0;
            this.REmpleado = 0;
            this.REstadoProducto = 0;
            this.RFactoria = 0;
            this.RFinca = 0;
            this.RPesada = 0;
            this.RProductores = 0;
            this.RReciboRecepcion = 0;
            this.RTipoProducto = 0;
            this.RTipoUsuario = 0;
            this.RTipoEmpleado = 0;
            this.RUsuario = 0;
            this.CCertificacion = 0;
            this.CComprobante = 0;
            this.CContrato = 0;
            this.CEmpleado = 0;
            this.CEstadoProducto = 0;
            this.CFactoria = 0;
            this.CFinca = 0;
            this.CPesada = 0;
            this.CProductores = 0;
            this.CReciboRecepcion = 0;
            this.CTipoProducto = 0;
            this.CTipoUsuario = 0;
            this.CTipoEmpleado = 0;
            this.CUsuario = 0;
        }
    }
}
