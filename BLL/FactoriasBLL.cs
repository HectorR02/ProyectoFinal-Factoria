using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

namespace BLL
{
    public class FactoriasBLL
    {
        public static bool Insertar(Factorias nuevo)
        {
            bool resultado = false;
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    if (Buscar(nuevo.FactoriaId) == null)
                        conexion.Factoria.Add(nuevo);
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
        public static Factorias Buscar(int factoriaId)
        {
            var factoria = new Factorias();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                   factoria = conexion.Factoria.Find(factoriaId);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return factoria;
        }
        public static bool Eliminar(Factorias existente)
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
        public static List<Factorias> GetList()
        {
            var lista = new List<Factorias>();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    if (conexion.Factoria.ToList().Count() > 0)
                        lista = conexion.Factoria.ToList();
                    else
                        lista = null;
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
                    SqlCommand comando = new SqlCommand("SELECT IDENT_CURRENT('Factorias')", conexion);
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
        public static int RNC(int factoriaId)
        {
            int rnc = 0;
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    Factorias fact = conexion.Factoria.Where(f => f.FactoriaId == factoriaId).FirstOrDefault();
                    rnc = fact.FactoriaRNC;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return rnc;
        }
    }
}
