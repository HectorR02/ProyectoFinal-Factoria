using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BLL
{
    public class ContratosBLL
    {
        public static bool Insertar(Contratos Nuevo)
        {
            bool resultado = false;
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    conexion.Contrato.Add(Nuevo);
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
        public static Contratos Buscar(int NumeroContrato)
        {
            var contrato = new Contratos();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    contrato = conexion.Contrato.Find(NumeroContrato);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return contrato;
        }
        public static bool Eliminar(Contratos Existente)
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
        public static List<Contratos> GetList()
        {
            var lista = new List<Contratos>();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    lista = conexion.Contrato.ToList();
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
