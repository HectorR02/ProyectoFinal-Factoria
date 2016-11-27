using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

namespace BLL
{
    public class TiposEmpleadosBLL
    {
        public static bool Insertar(TiposEmpleados nuevo)
        {
            bool resultado = false;
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    if (Buscar(nuevo.TipoEmpleadoId) == null)
                        conexion.TipoEmpleado.Add(nuevo);
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
        public static TiposEmpleados Buscar(int tipoEmpleadoId)
        {
            var tipo = new TiposEmpleados();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    tipo = conexion.TipoEmpleado.Find(tipoEmpleadoId);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return tipo;
        }
        public static bool Eliminar(TiposEmpleados existente)
        {
            bool resultado = false;
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    conexion.Entry(existente).State = EntityState.Deleted;
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
        public static List<TiposEmpleados> GetList()
        {
            var lista = new List<TiposEmpleados>();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    lista = conexion.TipoEmpleado.ToList();
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
                    SqlCommand comando = new SqlCommand("SELECT IDENT_CURRENT('TiposEmpleados')", conexion);
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
