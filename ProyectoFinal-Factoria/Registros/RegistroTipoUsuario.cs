﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Factoria.Registros
{
    public partial class RegistroTipoUsuario : Form
    {
        public RegistroTipoUsuario()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int Id;
            int.TryParse(tipoUsuarioIdTextBox.Text, out Id);
            var user =  BLL.TiposDeUsuariosBLL.Buscar(Id);
            if (user != null)
                nombreTextBox.Text = user.Nombre;
            else
                MessageBox.Show("El Tipo de Usuario solicitado no existe", "-- Consulta Fallida --", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            var user = BLL.TiposDeUsuariosBLL.Buscar(Utileria.ToInt(tipoUsuarioIdTextBox.Text));
            if (user != null)
                if (BLL.TiposDeUsuariosBLL.Eliminar(user))
                    MessageBox.Show("Registro Eliminado", "-- Transacción Exitosa --", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Ha ocurrido un error", "-- Transacción Fallida --", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("El registro al que ha intentado acceder\nno existe...", "-- AVISO --", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            BLL.TiposDeUsuariosBLL.Insertar(new Entidades.TiposDeUsuarios(Utileria.ToInt(tipoUsuarioIdTextBox.Text), nombreTextBox.Text));
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            tipoUsuarioIdTextBox.Clear();
            nombreTextBox.Clear();
            tipoUsuarioIdTextBox.Focus();
        }
    }
}
