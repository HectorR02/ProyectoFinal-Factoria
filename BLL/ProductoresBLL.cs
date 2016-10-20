using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BLL
{
    public class ProductoresBLL
    {
        public static bool Insertar(Productores nuevo)
        {
            bool resultado = false;
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    conexion.Productor.Add(nuevo);
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
        public static Productores Buscar(int ProductorId)
        {
            var productor = new Productores();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    productor = conexion.Productor.Find(ProductorId);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return productor;
        }
        public static bool Eliminar(Productores existente)
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
        public static List<Productores> GetList()
        {
            var lista = new List<Productores>();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    lista = conexion.Productor.ToList();
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
