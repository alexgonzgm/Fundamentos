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
    public partial class Form20SumarBotonesColeccion : Form
    {
        //DECLARAR A NIVEL DE CLASE LA COLECCION
        //DE Button
        List<Button> botones;

        public Form20SumarBotonesColeccion()
        {
            InitializeComponent();
            //INSTANCIAMOS LA COLECCION DE Button
            this.botones = new List<Button>();
            Random random = new Random();
            //QUEREMOS RELLENAR LA COLECCION DE BOTONES
            //CON TODOS LOS DIBUJADOS EN EL FORMULARIO
            //RECORREMOS CONTROLS DEL CONTENEDOR FORM
            foreach (Control control in this.Controls)
            {
                //PREGUNTAMOS POR SU TYPE
                if (control is Button)
                {
                    control.Text = random.Next(1, 99).ToString();
                    this.botones.Add((Button) control);
                }
            }

            //RECORREMOS NUESTRA COLECCION DE BOTONES
            foreach (Button boton in this.botones)
            {
                boton.Click += SumarNumeros;
            }
        }

        private void SumarNumeros(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            int num = int.Parse(boton.Text);
            int suma = int.Parse(this.txtsumanumeros.Text);
            suma += num;
            this.txtsumanumeros.Text = suma.ToString();
        }
    }
}
