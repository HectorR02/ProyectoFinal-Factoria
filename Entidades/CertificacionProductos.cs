using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class CertificacionProductos
    {
        [Key]
        public int CertificacionId { get; set; }

        public string Certificacion { get; set; }

        public CertificacionProductos(int id, string certidicacion)
        {
            this.CertificacionId = id;
            this.Certificacion = certidicacion;
        }

        public CertificacionProductos()
        {
        }
    }
}
