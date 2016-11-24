using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PesadasBLL
    {
        public static bool Insertar(Pesadas pesada)
        {
            bool resultado = false;
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    conexion.Pesada.Add(pesada);
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
        public static Pesadas Buscar(int pesadaId)
        {
            Pesadas pesada = new Pesadas();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    pesada = conexion.Pesada.Find(pesadaId);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return pesada;
        }
        public static bool Eliminar(Pesadas pesada)
        {
            bool resultado = false;
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    conexion.Entry(pesada).State = EntityState.Deleted;
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
        public static List<Pesadas> GetList()
        {
            List<Pesadas> lista = new List<Pesadas>();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    lista = conexion.Pesada.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;
        }

        public static bool Insertar(List<Pesadas> pesadas)
        {
            bool resultado = false;
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    foreach (var pesada in pesadas)
                    {
                        conexion.Pesada.Add(pesada);
                    }

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
        public static List<Pesadas> GetList(int noComprobante)
        {
            List<Pesadas> lista = new List<Pesadas>();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    lista = conexion.Pesada.Where(p => p.ComprobanteId == noComprobante).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;
        }
        public static bool Eliminar(int noComprobante)
        {
            bool resultado = false;
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    conexion.Pesada.RemoveRange(conexion.Pesada.Where(p => p.ComprobanteId == noComprobante));
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

        public static int Identity()
        {
            int identity = 0;
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DataBase\FactoriaDB.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection conexion = new SqlConnection(con))
            {
                try
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("SELECT IDENT_CURRENT('Pesadas')", conexion);
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
