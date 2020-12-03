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
    public partial class Form22TemperaturasAnuales : Form
    {
        List<int> temperaturas;
        public Form22TemperaturasAnuales()
        {
            InitializeComponent();
            this.temperaturas = new List<int>();
        }

        private void btngenerarmeses_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse("01/01/2020");
            Random random = new Random();
            this.lsttemperaturas.Items.Clear();
            this.temperaturas.Clear();
            for (int i = 1; i <= 12; i++)
            {
                String mes = fecha.ToString("MMMM");
                int aleat = random.Next(-20, 45);
                this.lsttemperaturas.Items.Add(mes + ": " + aleat);
                this.temperaturas.Add(aleat);
                fecha = fecha.AddMonths(1);
            }
        }

        private void btnmostrardatos_Click(object sender, EventArgs e)
        {
            int maxima, minima, media, suma;
            minima = this.temperaturas[0];
            maxima = this.temperaturas[0];
            suma = 0;
            foreach (int temp in this.temperaturas)
            {
                suma += temp;
                if (temp > maxima)
                {
                    maxima = temp;
                }
                minima = Math.Min(temp, minima);
            }
            media = suma / this.temperaturas.Count;
            this.txtmaxima.Text = maxima.ToString();
            this.txtminima.Text = minima.ToString();
            this.txtmedia.Text = media.ToString();
        }
    }
}
