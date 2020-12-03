using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form11Isbn : Form
    {
        public Form11Isbn()
        {
            InitializeComponent();
        }

        private void btnisbn_Click(object sender, EventArgs e)
        {
            String isbn = this.txtisbn.Text;
            if (isbn.Length == 10)
            {
                int suma = 0;
                for (int i = 0; i < isbn.Length; i++)
                {
                    char caracter = isbn[i];
                    int num = int.Parse(caracter.ToString());
                    int multi = num * (i + 1);
                    suma += multi;
                }
                if (suma%11 == 0)
                {
                    this.lblmensaje.Text = "ISBN correcto";
                }
                else
                {
                    this.lblmensaje.Text = "ISBN incorrecto";
                }
            }
            else
            {
                MessageBox.Show("El número ISBN debe tener 10 caracteres");
            }
        }
    }
}
