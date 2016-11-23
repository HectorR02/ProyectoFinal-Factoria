using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace BLL
{
    public class TipoProductosBLL
    {
        public static bool Insertar(TipoProductos Nuevo)
        {
            bool resultado = false;
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    conexion.TipoProducto.Add(Nuevo);
                    conexion.SaveChanges();
                    resultado = true;
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.ToString()); throw;
                }
            }
            return resultado;
        }
        public static TipoProductos Buscar(string Tipo)
        {
            var tipo = new TipoProductos();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    tipo = conexion.TipoProducto.Find(Tipo);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return tipo;
        }
        public static bool Eliminar(TipoProductos Existente)
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
        public static List<TipoProductos> GetList()
        {
            var lista = new List<TipoProductos>();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    lista = conexion.TipoProducto.ToList();
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
