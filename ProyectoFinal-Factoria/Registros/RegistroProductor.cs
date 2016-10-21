using Entidades;
using System;
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
    public partial class RegistroProductor : Form
    {
        public RegistroProductor()
        {
            InitializeComponent();
            var val = new Utileria(ProductorIdTextBox, "Ejemplo: 0001", NombresTextBox, "N");
            var val1 = new Utileria(NombresTextBox, "Ejemplo: Juan Pérez", CedulaMaskedTextBox, "L");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ProductorIdTextBox.Text))
            {
                if(!string.IsNullOrEmpty(NombresTextBox.Text))
                {
                    if(CedulaMaskedTextBox.MaskFull)
                    {
                        var cedula = CedulaMaskedTextBox.Text.Split('-');
                        string Ced = cedula[0] + cedula[1] + cedula[2];
                        BLL.ProductoresBLL.Insertar(new Productores() {
                            ProductorId = Convert.ToInt32(ProductorIdTextBox.Text),
                            FactoriaRNC = 1547,
                            Nombres = NombresTextBox.Text,
                            Cedula = Convert.ToInt64(Ced)
                        });
                    }
                    else
                    {
                        CedulaMaskedTextBox.Focus();
                    }
                }else
                {
                    NombresTextBox.Focus();
                }
            }
            else
            {
                ProductorIdTextBox.Focus();
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            ProductorIdTextBox.Clear();
            NombresTextBox.Clear();
            CedulaMaskedTextBox.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ProductorIdTextBox.Text))
            {
                if (!string.IsNullOrEmpty(NombresTextBox.Text))
                {
                    if (CedulaMaskedTextBox.MaskFull)
                    {
                        var cedula = CedulaMaskedTextBox.Text.Split('-');
                        string Ced = cedula[0] + cedula[1] + cedula[2];
                        NombresTextBox.Text = CedulaMaskedTextBox.Text;
                        BLL.ProductoresBLL.Eliminar(new Productores()
                        {
                            ProductorId = Convert.ToInt32(ProductorIdTextBox.Text),
                            FactoriaRNC = 1547,
                            Nombres = NombresTextBox.Text,
                            Cedula = Convert.ToInt64(Ced)
                        });
                    }
                    else
                    {
                        CedulaMaskedTextBox.Focus();
                    }
                }
                else
                {
                    NombresTextBox.Focus();
                }
            }
            else
            {
                ProductorIdTextBox.Focus();
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ProductorIdTextBox.Text))
            {
                var productor = BLL.ProductoresBLL.Buscar(Convert.ToInt32(ProductorIdTextBox.Text));
                if (productor != null)
                {
                    NombresTextBox.Text = productor.Nombres;
                    CedulaMaskedTextBox.Text = productor.Cedula.ToString();
                }
                else
                {
                    ProductorIdTextBox.Clear();
                    ProductorIdTextBox.Focus();
                }
            }
        }
    }
}
