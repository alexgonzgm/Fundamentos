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
    public partial class Form16MetodoReferencia : Form
    {
        public Form16MetodoReferencia()
        {
            InitializeComponent();
        }

        //METODO PARA COMPROBAR VALOR
        //EN TIPOS WRAPPER
        void DobleNumero(int num)
        {
            num = num * 2;
        }

        //METODO QUE RECIBE UNA CLASE POR REFERENCIA
        void CambiarColor (Button boton)
        {
            boton.BackColor = Color.Fuchsia;
        }

        //METODO QUE RECIBE UN WRAPPER O PRIMITIVO
        //Y LO UTILIZA COMO REFERENCIA
        void DobleReferencia(ref int num)
        {
            num = num * 2;
        }

        //SI NECESITAMOS DEVOLVER ALGO A LA LLAMADA
        //NO ES UN void
        int GetDoble(int num) {
            return num * 2;
        }

        private void btnllamada_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtnumero.Text);
            //LLAMAMOS AL METODO CON LA VARIABLE POR VALOR
            //this.DobleNumero(numero);
            //LLAMAMOS AL METODO WRAPPER POR REFERENCIA
            //SI DESEAMOS ENVIAR REFERENCIA, DEBEMOS INCLUIR
            //LA PALABRA ref
            //this.DobleReferencia(ref numero);
            int doble = this.GetDoble(numero);
            this.lblresultado.Text = "Doble: " + doble;
            //LLAMAMOS AL METODO QUE RECIBE UN OBJETO POR REFERENCIA (CLASE)
            this.CambiarColor(this.btnllamada);
        }


        private void MetodoEvento(object sender
            , EventArgs e)
        {
            
        }
    }
}
