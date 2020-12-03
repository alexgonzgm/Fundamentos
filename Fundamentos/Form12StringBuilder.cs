using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form12StringBuilder : Form
    {
        public Form12StringBuilder()
        {
            InitializeComponent();
            int[] numeros = new int[3] {14, 898, 33 };
            //SUMAR TODOS LOS NUMEROS DEL ARRAY
            int suma = 0;
            foreach (int num in numeros)
            {
                suma += num;
            }
            this.lbltiempo.Text = suma.ToString();
            
            foreach (Control control in this.Controls)
            {
                control.BackColor = Color.Yellow;
            }
        }

        private void btnreversestring_Click(object sender, EventArgs e)
        {
            //QUEREMOS MEDIR EL TIEMPO DE EJECUCION DEL PROCESO
            Stopwatch krono = new Stopwatch();
            krono.Start();
            //hol   0
            String texto = this.txttexto.Text;
            for (int i = 0; i < texto.Length; i++)
            {
                //RECUPERAMOS LA ULTIMA LETRA
                char letra = texto[texto.Length - 1];
                //ELIMINAMOS LA ULTIMA LETRA
                texto = texto.Remove(texto.Length - 1);
                //INSERTAMOS LA LETRA EN LA POSICION DEL INDICE
                texto = texto.Insert(i, letra.ToString());
            }
            this.txttexto.Text = texto;
            krono.Stop();
            TimeSpan interval = krono.Elapsed;
            this.lbltiempo.Text = "Segundos: "
                + interval.Seconds
                + "\nMilisegundos: "
                + interval.TotalMilliseconds;
        }

        private void btnreversestringbuilder_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            krono.Start();
            StringBuilder texto = new StringBuilder();
            texto.Append(this.txttexto.Text);
            for (int i = 0; i < texto.Length; i++)
            {
                char letra = texto[texto.Length - 1];
                texto = texto.Remove(texto.Length - 1, 1);
                texto = texto.Insert(i, letra);
            }
            this.txttexto.Text = texto.ToString();
            krono.Stop();
            this.lbltiempo.Text = "Segundos: "
                + krono.Elapsed.Seconds
                + "\nMilisegundos: "
                + krono.Elapsed.TotalMilliseconds;
        }
    }
}
