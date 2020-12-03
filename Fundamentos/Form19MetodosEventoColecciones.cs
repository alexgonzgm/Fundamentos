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
    public partial class Form19MetodosEventoColecciones : Form
    {
        int contador; //MAL
        //NUNCA SE INSTANCIA UN OBJETO AQUI
        List<Button> botones;

        public Form19MetodosEventoColecciones()
        {
            InitializeComponent();
            this.contador = 0;
            //LOS OBJETOS SE INSTANCIAN EN EL CONSTRUCTOR
            this.botones = new List<Button>();
            //this.botones.Add(this.button1);
            //this.botones.Add(this.button2);
            //this.botones.Add(this.button3);
            //COMO HABLAMOS DE COLECCIONES EN FORMS
            //TENEMOS UNA COLECCION QUE ES CONTROLS.
            // this.Controls
            //SI QUEREMOS GUARDAR TODOS LOS BOTONES
            //DEL FORMULARIO, PODEMOS RECORRER LA COLECCION
            // this.Controls Y ALMACENAR SOLO LOS BOTONES EN LA COLECCION
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    this.botones.Add((Button)control);
                }
            }
        }

        //NO TIENE NADA QUE VER UN METODO DE EVENTO (CUANDO)
        //CON UN METODO PROPIO DE LA CLASE
        void AddEvents(bool activar)
        {
            foreach (Button boton in this.botones)
            {
                if (activar == true)
                {
                    boton.Click += MostrarMensaje;
                }
                else
                {
                    boton.Click -= MostrarMensaje;
                }
            }
        }

        private void chkasociarmetodos_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkasociarmetodos.Checked == true)
            {
                this.contador += 1;
                this.AddEvents(true);
            }
            else
            {
                this.contador -= 1;
                this.AddEvents(false);
            }
            this.lblnumeroeventos.Text = "Eventos: " + this.contador;
        }

        private void MostrarMensaje(object sender, EventArgs e)
        {
            //MessageBox.Show("Pulsado");
            //VIENEN VARIOS OBJETOS...CUANTOS CONTROLES LEEN AQUI??
            //COMO DIFERENCIAMOS CADA CONTROL INDIVIDUAL??
            //EL OBJETO QUE REALIZA LA LLAMADA AL METODO?
            //  sender viene como un object, pero qué es en realidad??
            // tenemos alguna forma de convertir un object en Button??
            Button boton = (Button)sender;
            boton.BackColor = Color.LightGreen;
        }
    }
}
