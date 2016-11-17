using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinal_Factoria
{
    class Utileria
    {
        TextBox caja;
        string Texto;
        TextBoxBase siguiente;
        public Utileria(TextBox externa, string texto, TextBoxBase sig, string Modo)
        {
            caja = externa;
            Texto = texto;
            siguiente = sig;
            if (Modo.Equals("LN"))
                caja.KeyPress += new KeyPressEventHandler(cajaLN_KeyPress);
            else if (Modo.Equals("L"))
                caja.KeyPress += new KeyPressEventHandler(cajaL_KeyPress);
            else if (Modo.Equals("N"))
                caja.KeyPress += new KeyPressEventHandler(cajaN_KeyPress);
            else if (Modo.Equals("Pass"))
                caja.KeyPress += new KeyPressEventHandler(cajaPass_KeyPress);
        }

        private void cajaLN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrEmpty(caja.Text))
                {
                    caja.Text = Texto;
                    caja.ForeColor = Color.Silver;
                }
                siguiente.Focus();
            }
            else
                if (Char.IsDigit(e.KeyChar) || Char.IsLetter(e.KeyChar))
                if (caja.Text.Equals(Texto) || caja.ForeColor == Color.Silver)
                {
                    caja.Clear();
                    caja.ForeColor = Color.Black;
                }
        }
        private void cajaL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrEmpty(caja.Text))
                {
                    caja.Text = Texto;
                    caja.ForeColor = Color.Silver;
                }
                siguiente.Focus();
            }
            else
                if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                if (caja.Text.Equals(Texto) || caja.ForeColor == Color.Silver)
                {
                    caja.Clear();
                    caja.ForeColor = Color.Black;
                }
            }
            else
                e.Handled = true;
        }
        private void cajaN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrEmpty(caja.Text))
                {
                    caja.Text = Texto;
                    caja.ForeColor = Color.Silver;
                }
                siguiente.Focus();
            }
            else
                if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                if (caja.Text.Equals(Texto) || caja.ForeColor == Color.Silver)
                {
                    caja.Clear();
                    caja.ForeColor = Color.Black;
                }
            }
            else
                e.Handled = true;
        }
        private void cajaPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrEmpty(caja.Text))
                {
                    caja.Text = "Contraseña";
                    caja.ForeColor = Color.Silver;
                    if (caja.PasswordChar == '*')
                        caja.PasswordChar = '\0';
                }
                siguiente.Focus();
            }
            else
                if (Char.IsDigit(e.KeyChar) || Char.IsLetter(e.KeyChar))
                if (caja.Text.Equals("Contraseña") || caja.ForeColor == Color.Silver)
                {
                    caja.Clear();
                    caja.PasswordChar = '*';
                    caja.ForeColor = Color.Black;
                }
        }

        public static int ToInt(string cadena)
        {
            int entero;
            int.TryParse(cadena, out entero);

            return entero;
        }
    }
}
