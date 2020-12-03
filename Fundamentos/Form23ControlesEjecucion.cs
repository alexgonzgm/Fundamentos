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
    public partial class Form23ControlesEjecucion : Form
    {
        public Form23ControlesEjecucion()
        {
            InitializeComponent();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int posx = 10;
            for (int i = 1; i <= 5; i++)
            {
                //INSTANCIAMOS UN CONTROL CHECKBOX
                CheckBox chk = new CheckBox();
                chk.Text = random.Next(1, 50).ToString();
                chk.AutoSize = true;
                chk.Location = new Point(posx, 10);
                posx += 70;
                this.panel1.Controls.Add(chk);
                chk.CheckedChanged += RealizarOperacion;
            }
        }

        private void RealizarOperacion(object sender, EventArgs e)
        {
            int valor = int.Parse(this.txtvalor.Text);
            CheckBox chk = (CheckBox)sender;
            int num = int.Parse(chk.Text);
            if (chk.Checked == true)
            {
                valor += num;
            }
            else
            {
                valor -= num;
            }
            this.txtvalor.Text = valor.ToString();
        }
    }
}
