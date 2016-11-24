using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
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
                catch (Exception)
                {
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
                catch (Exception)
                {
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

        public static int Identity()
        {
            int identity = 0;
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DataBase\FactoriaDB.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection conexion = new SqlConnection(con))
            {
                try
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("SELECT IDENT_CURRENT('Usuarios')", conexion);
                    identity = Convert.ToInt32(comando.ExecuteScalar());
                    conexion.Close();

                }
                catch (Exception)
                {
                    throw;
                }
            }
            return identity;
        }

        public static Usuarios Buscar(string nombre, string contraseña)
        {
            Usuarios user = null;
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    user = conexion.Usuario.Where(u => u.Nombre.Equals(nombre) && u.Contraseña.Equals(contraseña)).FirstOrDefault();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return user;
        }
    }
}
