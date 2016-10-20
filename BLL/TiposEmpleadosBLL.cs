using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BLL
{
    public class TiposEmpleadosBLL
    {
        public static bool Insertar(TiposEmpleados Nuevo)
        {
            bool resultado = false;
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    conexion.TipoEmpleado.Add(Nuevo);
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
        public static TiposEmpleados Buscar(string TipoEmpleado)
        {
            var tipo = new TiposEmpleados();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    tipo = conexion.TipoEmpleado.Find(TipoEmpleado);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return tipo;
        }
        public static bool Eliminar(TiposEmpleados Existente)
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
    }
}
