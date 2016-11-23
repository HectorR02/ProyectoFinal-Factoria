using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class UsuariosBLL
    {
        public static bool Insertar(Usuarios nuevo)
        {
            bool resultado = false;
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    conexion.Usuario.Add(nuevo);
                    conexion.SaveChanges();
                    resultado = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    throw;
                }
            }
            return resultado;
        }

        public static Usuarios Buscar(int usuarioId)
        {
            var User = new Usuarios();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    User = conexion.Usuario.Find(usuarioId);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    throw;
                }
            }
            return User;
        }

        public static bool Eliminar(Usuarios existente)
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

        public static List<Usuarios> GetList()
        {
            var lista = new List<Usuarios>();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    lista = conexion.Usuario.ToList();
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
