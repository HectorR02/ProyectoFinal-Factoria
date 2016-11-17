using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    }
}
