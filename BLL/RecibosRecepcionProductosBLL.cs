using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BLL
{
    public class RecibosRecepcionProductosBLL
    {
        public static bool Insertar(RecibosRecepcionProductos Nuevo)
        {
            bool resultado = false;
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    conexion.ReciboRecepcionProducto.Add(Nuevo);
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
        public static RecibosRecepcionProductos Buscar(int NumeroRecibo)
        {
            var recibo = new RecibosRecepcionProductos();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    recibo = conexion.ReciboRecepcionProducto.Find(NumeroRecibo);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return recibo;
        }
        public static bool Eliminar(RecibosRecepcionProductos Existente)
        {
            bool Resultado = false;
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    conexion.Entry(Existente).State = EntityState.Deleted;
                    conexion.SaveChanges();
                    Resultado = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return Resultado;
        }
        public static List<RecibosRecepcionProductos> GetList()
        {
            var lista = new List<RecibosRecepcionProductos>();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    lista = conexion.ReciboRecepcionProducto.ToList();
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
