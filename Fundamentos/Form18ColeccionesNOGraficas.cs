using System;
using System.Collections;
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
    public partial class Form18ColeccionesNOGraficas : Form
    {
        public Form18ColeccionesNOGraficas()
        {
            InitializeComponent();
            //COLECCION DE OBJETOS
            ArrayList coleccion = new ArrayList();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);
            coleccion.Add(this.textBox1);
            //SI QUEREMOS CAMBIAR EL COLOR DE FONDO
            //((Button)coleccion[0]).BackColor = Color.Yellow;
            ////UN BUCLE EACH PERMITE LA CONVERSION
            ////DE OBJECT A CLASE DEFINIDA
            //foreach (Control boton in coleccion)
            //{
            //    boton.BackColor = Color.LightGreen;
            //}

            //COLECCIONES GENERICAS SON MAS EFICIENTES
            //TIENEN TIPADO Y MAS FACIL DETECTAR ERRORES
            //EN COMPILACION
            List<Control> botones = new List<Control>();
            botones.Add(this.button1);
            botones.Add(this.button2);
            botones.Add(this.button3);
            botones[0].BackColor = Color.LightCoral;
            //EL COMPILADOR DETECTA ERRORES DE PROGRAMACION
            botones.Add(this.textBox1);
            //RECORRER TODOS LOS OBJETOS DE LA COLECCION
            foreach (Control control in botones)
            {
                control.BackColor = Color.LightBlue;
                //Y SI DESEAMOS REALIZAR ALGO SOLO CON LOS
                //TEXTBOX???
                //PARA PREGUNTAR SI UN OBJETO ES DE UNA CLASE
                //DETERMINADA SE UTILIZA EL OPERADOR is
                if (control is TextBox)
                {
                    control.BackColor = Color.LightGoldenrodYellow;
                    //LA CLASE TEXTBOX TIENE UN METODO QUE ES .Paste()
                    //PEGA DEL PORTAPAPELES EN LA CAJA
                    ((TextBox)control).Paste();
                    //control.Paste();
                }
            }
        }
    }
}
