using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BLL
{
    public class TiposDeUsuariosBLL
    {
        public static bool Insertar(TiposDeUsuarios nuevo)
        {
            bool resultado = false;
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    conexion.TipoUsuario.Add(nuevo);
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

        public static TiposDeUsuarios Buscar(int tipoUsuarioId)
        {
            var tipo = new TiposDeUsuarios();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    tipo = conexion.TipoUsuario.Find(tipoUsuarioId);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return tipo;
        }

        public static bool Eliminar(TiposDeUsuarios existente)
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

        public static List<TiposDeUsuarios> GetList()
        {
            var lista = new List<TiposDeUsuarios>();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    lista = conexion.TipoUsuario.ToList();
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
