using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

namespace BLL
{
    public class RecibosRecepcionProductosBLL
    {
        public static bool Insertar(RecibosRecepcionProductos nuevo)
        {
            bool resultado = false;
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    if (Buscar(nuevo.NumeroRecibo) == null)
                        conexion.ReciboRecepcionProducto.Add(nuevo);
                    else
                        conexion.Entry(nuevo).State = EntityState.Modified;
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
        public static RecibosRecepcionProductos Buscar(int numeroRecibo)
        {
            var recibo = new RecibosRecepcionProductos();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    recibo = conexion.ReciboRecepcionProducto.Find(numeroRecibo);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return recibo;
        }
        public static bool Eliminar(RecibosRecepcionProductos existente)
        {
            bool Resultado = false;
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    conexion.Entry(existente).State = EntityState.Deleted;
                    conexion.SaveChanges();
                    Resultado = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return Resultado;
        }
        public static List<RecibosRecepcionProductos> GetList()
        {
            var lista = new List<RecibosRecepcionProductos>();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    lista = conexion.ReciboRecepcionProducto.ToList();
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
                    SqlCommand comando = new SqlCommand("SELECT IDENT_CURRENT('RecibosRecepcionProductos')", conexion);
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
