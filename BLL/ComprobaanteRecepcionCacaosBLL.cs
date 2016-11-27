using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace BLL
{
    public class ComprobaanteRecepcionCacaosBLL
    {
        public static bool Insertar(ComprobanteRecepcionCacaos nuevo)
        {
            bool resultado = false;
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    if (Buscar(nuevo.NumeroComprobante) == null)
                        conexion.ComprobanteRecepcionCacao.Add(nuevo);
                    else
                        conexion.Entry(nuevo).State = EntityState.Modified;
                    conexion.SaveChanges();
                    resultado = true;
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.ToString());
                }
            }
            return resultado;
        }
        public static ComprobanteRecepcionCacaos Buscar(int numeroComprobante)
        {
            var Comprobante = new ComprobanteRecepcionCacaos();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    Comprobante = conexion.ComprobanteRecepcionCacao.Find(numeroComprobante);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return Comprobante;
        }
        public static bool Eliminar(ComprobanteRecepcionCacaos existente)
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
        public static List<ComprobanteRecepcionCacaos> GetList()
        {
            var lista = new List<ComprobanteRecepcionCacaos>();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    lista = conexion.ComprobanteRecepcionCacao.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;
        }

        public static ComprobanteRecepcionCacaos Buscar(string nombreProductor, Int64 numeroCedula)
        {
            var Comprobante = new ComprobanteRecepcionCacaos();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    Comprobante = conexion.ComprobanteRecepcionCacao.Where(x => x.NombreProductor == nombreProductor && x.CedulaProductor == numeroCedula).SingleOrDefault();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return Comprobante;
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
                    SqlCommand comando = new SqlCommand("SELECT IDENT_CURRENT('ComprobanteRecepcionCacaos')", conexion);
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
        public static List<ComprobanteRecepcionCacaos> GetList(int productoId, DateTime desde, DateTime hasta)
        {
            var lista = new List<ComprobanteRecepcionCacaos>();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    lista.AddRange(conexion.ComprobanteRecepcionCacao.Where(crc => crc.ProductorId == productoId && (crc.Fecha.Day >= desde.Day && crc.Fecha.Month >= desde.Month && crc.Fecha.Year >= desde.Year) && (crc.Fecha.Day <= hasta.Day && crc.Fecha.Month <= hasta.Month && crc.Fecha.Year <= hasta.Year)));
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;
        }

        public static ComprobanteRecepcionCacaos Buscar(string nombreProductor, Int64 numeroCedula, DateTime fecha)
        {
            var comprobante = new ComprobanteRecepcionCacaos();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    comprobante = conexion.ComprobanteRecepcionCacao.Where(c => (c.NombreProductor.Equals(nombreProductor) && c.CedulaProductor == numeroCedula) && (c.Fecha.Day == fecha.Day && c.Fecha.Month == fecha.Month && c.Fecha.Year == fecha.Year)).FirstOrDefault();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return comprobante;
        }
    }
}
