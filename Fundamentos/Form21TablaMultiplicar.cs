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
    public partial class Form21TablaMultiplicar : Form
    {
        List<TextBox> cajas;

        public Form21TablaMultiplicar()
        {
            InitializeComponent();
            this.cajas = new List<TextBox>();
            foreach (Control c in this.groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    this.cajas.Add((TextBox)c);
                }
            }
            this.cajas.Reverse();
        }

        private void btnmostrartabla_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtnumero.Text);
            //REALIZAMOS UN BUCLE DE 1 A NUMERO DE CAJAS
            for (int i = 1; i <= this.cajas.Count; i++)
            {
                int multi = numero * i;
                this.cajas[i - 1].Text = multi.ToString();
            }
        }
    }
}
