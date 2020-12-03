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
    public partial class Form04CambiarForm : Form
    {
        public Form04CambiarForm()
        {
            InitializeComponent();
        }

        private void btnposicion_Click(object sender, EventArgs e)
        {
            int posx = int.Parse(this.txtposicionx.Text);
            //VAMOS A PREGUNTAR SI ES POSITIVO, NEGATIVO O ZERO
            if (posx > 0)
            {
                this.label1.Text = "POSITIVO";
            }else if (posx == 0)
            {
                this.label1.Text = "ZERO";
            }
            else
            {
                this.label1.Text = "NEGATIVO";
            }

            int numero = 1;
            switch (numero)
            {
                case 0:
                case 1:
                    this.label1.Text = "Valor 0 o 1";
                    break;
                case 2:
                    this.label2.Text = "Valor 2";
                    break;
                default:
                    this.label1.Text = "Otros valores";
                    break;
            }





            int posy = int.Parse(this.txtposiciony.Text);
            this.btnposicion.Location = new Point(posx, posy);



        }

        private void btncolor_Click(object sender, EventArgs e)
        {
            int rojo = int.Parse(this.txtrojo.Text);
            int azul = int.Parse(this.txtazul.Text);
            int verde = int.Parse(this.txtverde.Text);
            this.BackColor = Color.FromArgb(rojo, verde, azul);
        }
    }
}
