using Entidades;
using System.Data.Entity;

namespace DAL
{
    public  class FactoriaDB: DbContext
    {
        public FactoriaDB(): base("name=Factoria")
        {

        }
        public virtual DbSet<Productores> Productor { get; set; }

        public virtual DbSet<Fincas> Finca { get; set; }

        public virtual DbSet<Factorias> Factoria { get; set; }

        public virtual DbSet<Empleados> Empleado { get; set; }

        public virtual DbSet<Contratos> Contrato { get; set; }

        public virtual DbSet<TiposEmpleados> TipoEmpleado { get; set; }

        public virtual DbSet<RecibosRecepcionProductos> ReciboRecepcionProducto { get; set; }

        public virtual DbSet<ComprobanteRecepcionCacaos> ComprobanteRecepcionCacao { get; set; }

        public virtual DbSet<CertificacionProductos> CertificadoProducto { get; set; }

        public virtual DbSet<EstadoProductos> EstadoProducto { get; set; }

        public virtual DbSet<TipoProductos> TipoProducto { get; set; }

        public virtual DbSet<Usuarios> Usuario { get; set; }

        public DbSet<TiposDeUsuarios> TipoUsuario { get; set; }
    }
}
