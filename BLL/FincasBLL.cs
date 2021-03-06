﻿using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
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
                    if (Buscar(nuevo.FincaId) == null)
                        conexion.Finca.Add(nuevo);
                    else
                        conexion.Entry(nuevo).State = EntityState.Modified;
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
        public static Fincas Buscar(int fincaId)
        {
            var finca = new Fincas();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    finca = conexion.Finca.Find(fincaId);
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

        public static int Identity()
        {
            int identity = 0;
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DataBase\FactoriaDB.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection conexion = new SqlConnection(con))
            {
                try
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("SELECT IDENT_CURRENT('Fincas')", conexion);
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
        public static bool Insertar(List<Fincas> fincas)
        {
            bool resultado = false;
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    conexion.Finca.AddRange(fincas);
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
        public static List<Fincas> GetList(int productorId)
        {
            var lista = new List<Fincas>();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    lista = conexion.Finca.Where(f => f.ProductorId == productorId).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;
        }
        public static bool Eliminar(int productorId)
        {
            bool resultado = false;
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    conexion.Finca.RemoveRange(conexion.Finca.Where(f => f.ProductorId == productorId));
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
    }
}
