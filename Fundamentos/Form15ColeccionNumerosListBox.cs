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
    public partial class Form15ColeccionNumerosListBox : Form
    {
        public Form15ColeccionNumerosListBox()
        {
            InitializeComponent();
        }

        private void btngenerarnumeros_Click(object sender, EventArgs e)
        {
            this.lstnumeros.Items.Clear();
            Random random = new Random();
            for (int i = 1; i <= 10; i++)
            {
                int aleat = random.Next(1, 50);
                this.lstnumeros.Items.Add(aleat);
            }
            this.txtsuma.Text = "0";
            this.txtpares.Text = "0";
            this.txtimpares.Text = "0";
        }

        private void btnmostrardatos_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int sumapares = 0;
            int sumaimpares = 0;
            foreach (object obj in this.lstnumeros.Items)
            {
                int num = (int) obj;
                suma += num;
                if (num % 2 == 0)
                {
                    sumapares += num;
                }
                else
                {
                    sumaimpares += num;
                }
            }
            this.txtsuma.Text = suma.ToString();
            this.txtpares.Text = sumapares.ToString();
            this.txtimpares.Text = sumaimpares.ToString();
        }
    }
}
