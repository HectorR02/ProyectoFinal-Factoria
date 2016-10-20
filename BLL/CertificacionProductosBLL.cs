using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BLL
{
    public class CertificacionProductosBLL
    {
        public static bool Insertar(CertificacionProductos Nuevo)
        {
            bool resultado = false;
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    conexion.CertificadoProducto.Add(Nuevo);
                    conexion.SaveChanges();
                    resultado = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return resultado;
        }
        public static CertificacionProductos Buscar(string Certificacion)
        {
            var certificado = new CertificacionProductos();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    certificado = conexion.CertificadoProducto.Find(Certificacion);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return certificado;
        }
        public static bool Eliminar(CertificacionProductos Existente)
        {
            bool resultado = false;
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    conexion.Entry(Existente).State = EntityState.Deleted;
                    conexion.SaveChanges();
                    resultado = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return resultado;
        }
        public static List<CertificacionProductos> GetList()
        {
            var lista = new List<CertificacionProductos>();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    lista = conexion.CertificadoProducto.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;
        }
    }
}
