using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BLL
{
    public class EmpleadosBLL
    {
        public static bool Insertar(Empleados Nuevo)
        {
            bool resultado = false;
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    conexion.Empleado.Add(Nuevo);
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
        public static Empleados Buscar(int EmpleadoId)
        {
            var empleado = new Empleados();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    empleado = conexion.Empleado.Find(EmpleadoId);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return empleado;
        }
        public static bool Eliminar(Empleados Existente)
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
        public static List<Empleados> GetList()
        {
            var lista = new List<Empleados>();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    lista = conexion.Empleado.ToList();
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
