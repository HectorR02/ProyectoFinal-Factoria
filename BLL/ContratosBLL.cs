using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

namespace BLL
{
    public class ContratosBLL
    {
        public static bool Insertar(Contratos nuevo)
        {
            bool resultado = false;
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    if (Buscar(nuevo.NumeroContrato) == null)
                        conexion.Contrato.Add(nuevo);
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
        public static Contratos Buscar(int numeroContrato)
        {
            var contrato = new Contratos();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    contrato = conexion.Contrato.Find(numeroContrato);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return contrato;
        }
        public static bool Eliminar(Contratos existente)
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
        public static List<Contratos> GetList()
        {
            var lista = new List<Contratos>();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    lista = conexion.Contrato.ToList();
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
                    SqlCommand comando = new SqlCommand("SELECT IDENT_CURRENT('Contratos')", conexion);
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
        public static List<Contratos> GetList(int rnc, DateTime desde, DateTime hasta)
        {
            var lista = new List<Contratos>();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    lista.AddRange(conexion.Contrato.Where(c => c.FactoriaRNC == rnc && (c.FechaEmision.Day >= desde.Day && c.FechaEmision.Month >= desde.Month && c.FechaEmision.Year >= desde.Year) && (c.FechaEmision.Day <= hasta.Day && c.FechaEmision.Month <= hasta.Month && c.FechaEmision.Year <= hasta.Year)));
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;
        }
        public static List<Contratos> GetList(int factoriaId)
        {
            var lista = new List<Contratos>();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    lista.AddRange(conexion.Contrato.Where(c => c.FactoriaRNC == factoriaId));
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
