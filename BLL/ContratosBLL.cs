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
        public static bool Insertar(Contratos Nuevo)
        {
            bool resultado = false;
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    conexion.Contrato.Add(Nuevo);
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
        public static Contratos Buscar(int NumeroContrato)
        {
            var contrato = new Contratos();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    contrato = conexion.Contrato.Find(NumeroContrato);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return contrato;
        }
        public static bool Eliminar(Contratos Existente)
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
    }
}
