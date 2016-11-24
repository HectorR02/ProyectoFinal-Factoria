using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

namespace BLL
{
    public class EstadoProductosBLL
    {
        public static bool Insertar(EstadoProductos Nuevo)
        {
            bool resultado = false;
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    conexion.EstadoProducto.Add(Nuevo);
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
        public static EstadoProductos Buscar(string Estado)
        {
            var estado = new EstadoProductos();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    estado = conexion.EstadoProducto.Find(Estado);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return estado;
        }
        public static bool Elimiar(EstadoProductos Existente)
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
        public static List<EstadoProductos> GetList()
        {
            var lista = new List<EstadoProductos>();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    lista = conexion.EstadoProducto.ToList();
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
                    SqlCommand comando = new SqlCommand("SELECT IDENT_CURRENT('EstadoProductos')", conexion);
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
