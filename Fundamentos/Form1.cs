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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnpulsar_Click(object sender, EventArgs e)
        {
            //CUANDO PULSEMOS EL BOTON
            //PROPIEDADES DE TIPO PRIMITIVO (String, int, double)
            txtcaja.Text = "Soy texto";
            //LA PALABRA CLAVE this INDICA LA CLASE
            //SOBRE LA QUE ESTAMOS TRABAJANDO. OPCIONAL
            //SI NO LO PONGO, POR DEFECTO, RECUPERA
            //EL NOMBRE DE VARIABLE POR CERCANIA
            this.txtcaja.Width = 400;
            //PROPIEDADES DE OBJETOS
            //DEBEMOS CREAR OBJETOS DE LA CLASE new Clase()
            //QUEREMOS CAMBIAR EL TAMAÑO DEL BOTON
            //PROPIEDAD: Size
            this.btnpulsar.Size = new Size(350, 250);
            //ALGUNAS CLASES, NO SE CREAN, SINO QUE SE
            //UTILIZAN DIRECTAMENTE
            this.BackColor = Color.Gold;
            //ENUMERACIONES.  EN AMARILLO
            //UNA ENUMERACION ES UNA SERIE DE POSIBILIDADES PARA
            //UNA PROPIEDAD.  EN REALIDAD SON TIPOS INT, PERO
            //LOS MUESTRA COMO STRING
            this.txtcaja.TextAlign = HorizontalAlignment.Right;
        }
    }
}
