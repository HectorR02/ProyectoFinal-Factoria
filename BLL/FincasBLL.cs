using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BLL
{
    public class FincasBLL
    {
        public static bool Insertar(Fincas nuevo)
        {
            bool resultado = false;
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    conexion.Finca.Add(nuevo);
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
        public static Fincas Buscar(int NumeroParcela)
        {
            var finca = new Fincas();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    finca = conexion.Finca.Find(NumeroParcela);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return finca;
        }
        public static bool Eliminar(Fincas existente)
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
        public static List<Fincas> GetList()
        {
            var lista = new List<Fincas>();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    lista = conexion.Finca.ToList();
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
