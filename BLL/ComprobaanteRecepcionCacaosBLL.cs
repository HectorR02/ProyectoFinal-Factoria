﻿using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace BLL
{
    public class ComprobaanteRecepcionCacaosBLL
    {
        public static bool Insertar(ComprobanteRecepcionCacaos Nuevo)
        {
            bool resultado = false;
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    conexion.ComprobanteRecepcionCacao.Add(Nuevo);
                    conexion.SaveChanges();
                    resultado = true;
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.ToString());
                }
            }
            return resultado;
        }
        public static ComprobanteRecepcionCacaos Buscar(int NumeroComprobante)
        {
            var Comprobante = new ComprobanteRecepcionCacaos();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    Comprobante = conexion.ComprobanteRecepcionCacao.Find(NumeroComprobante);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return Comprobante;
        }
        public static bool Eliminar(ComprobanteRecepcionCacaos Existente)
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
        public static List<ComprobanteRecepcionCacaos> GetList()
        {
            var lista = new List<ComprobanteRecepcionCacaos>();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    lista = conexion.ComprobanteRecepcionCacao.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return lista;
        }

        public static ComprobanteRecepcionCacaos Buscar(string NombreProductor, Int64 NumeroCedula)
        {
            var Comprobante = new ComprobanteRecepcionCacaos();
            using (var conexion = new FactoriaDB())
            {
                try
                {
                    Comprobante = conexion.ComprobanteRecepcionCacao.Where(x => x.NombreProductor == NombreProductor && x.CedulaProductor == NumeroCedula).SingleOrDefault();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return Comprobante;
        }
    }
}
