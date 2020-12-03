using ProyectoClases;
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
    public partial class Form25ClasesMeses : Form
    {
        List<Mes> meses;

        public Form25ClasesMeses()
        {
            InitializeComponent();
            this.meses = new List<Mes>();
        }

        private void btngenerardatos_Click(object sender, EventArgs e)
        {
            this.meses.Clear();
            this.lstmeses.Items.Clear();
            DateTime fecha = DateTime.Parse("01/01/1995");
            Random random = new Random();
            for (int i = 1; i <= 12; i++)
            {
                int max = random.Next(10, 40);
                int min = random.Next(-20, 10);
                String nombre = fecha.ToString("MMMM");
                fecha = fecha.AddMonths(1);
                Mes mes = new Mes(nombre, max, min);
                //mes.Nombre = nombre;
                this.meses.Add(mes);
                this.lstmeses.Items.Add(nombre);
            }
        }

        private void lstmeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = this.lstmeses.SelectedIndex;
            Mes mes = this.meses[indice];
            this.txtnombre.Text = mes.Nombre;
            this.txtmaxima.Text = mes.Maxima.ToString();
            this.txtminima.Text = mes.Minima.ToString();
            this.txtmedia.Text = mes.GetMedia().ToString();
        }
    }
}
