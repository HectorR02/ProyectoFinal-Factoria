using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
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

        public static int Identity()
        {
            int identity = 0;
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DataBase\FactoriaDB.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection conexion = new SqlConnection(con))
            {
                try
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("SELECT IDENT_CURRENT('CertificacionProductos')", conexion);
                    identity = Convert.ToInt32(comando.ExecuteScalar());
                    conexion.Close();

                }
                catch (Exception)
                {
                    throw;
                }
            }
            return identity;
        }
    }
}
