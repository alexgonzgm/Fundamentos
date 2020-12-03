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
    public partial class FormConversion : Form
    {
        public FormConversion()
        {
            InitializeComponent();
        }

        private void FormConversion_Load(object sender, EventArgs e)
        {
            //CONVERSION AUTOMATICA
            double mayor = 99;
            int menor = 99;
            //SI IGUALAMOS MAYOR CAPACIDAD A MENOR
            //LA CONVERSION ES AUTOMATICA
            mayor = menor;
            //ERROR DE COMPILACION SI LO HACEMOS AL REVES
            //menor = mayor;


            //CASTING ENTRE PRIMITIVOS
            //LOS PRIMITIVOS ESTAN TODOS EN MINUSCULAS
            //  ( TIPO A CONVERTIR )OBJETO
            short mini = 44;  //MENOR
            int numero = 88;  //MAYOR
            mini = (short)numero;

            //CONVERSION DE STRING A TIPO PRIMITIVO
            //UN TIPO String ES UNA CLASE. 
            //TIENE LA PRIMERA LETRA MAYUSCULA
            //PARA PODER CONVERTIR CUALQUIER STRING
            //A PRIMITIVO SE UTILIZAN METODOS DE LAS CLASES
            //PRIMITIVAS.  SE LLAMA Parsear
            //  tipoprimitivo.Parse(String)
            String texto = "34567";
            int num = int.Parse(texto);
            double doble = double.Parse(texto);

            //CONVERTIR PRIMITIVOS A STRING
            //La clase System.Object contiene un método para
            // convertir a String.  Es el método
            // .ToString()
            //CUALQUIER OBJETO TIENE .ToString()
            int valor = 999;
            String dato = valor.ToString();
            dato = this.ToString();
            dato = this.BackColor.ToString();

            //LO METODOS PUEDEN TENER TAMBIEN 
            //SOBRECARGA
            MessageBox.Show("Texto", "titulo"
                , MessageBoxButtons.YesNoCancel
                , MessageBoxIcon.Information);
        }
    }
}
