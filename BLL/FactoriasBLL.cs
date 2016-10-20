using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BLL
{
    public class FactoriasBLL
    {
        public static bool Insertar(Factorias Nuevo)
        {
            bool resultado = false;
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    conexion.Factoria.Add(Nuevo);
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
        public static Factorias Buscar(int RNC)
        {
            var factoria = new Factorias();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                   factoria = conexion.Factoria.Find(RNC);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return factoria;
        }
        public static bool Eliminar(Factorias Existente)
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
        public static List<Factorias> GetList()
        {
            var lista = new List<Factorias>();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    lista = conexion.Factoria.ToList();
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
