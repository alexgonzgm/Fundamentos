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
    public partial class Form10SumarNumeros : Form
    {
        public Form10SumarNumeros()
        {
            InitializeComponent();
        }

        private void btnsumarnumeros_Click(object sender, EventArgs e)
        {
            String textonumeros = this.txtnumeros.Text;
            int suma = 0;
            //RECORREMOS TODOS LOS CARACTERES DEL STRING
            for (int i = 0; i < textonumeros.Length; i++)
            {
                //RECUPERAMOS CADA CARACTER
                char caracter = textonumeros[i];
                //CONVERTIMOS EL CARACTER A NUMERO
                //ESTA CONVERSION RECUPERA EL CODIGO ASCII
                //int num = caracter;
                //NOSOTROS NECESITAMOS EL LITERAL
                int num = int.Parse(caracter.ToString());
                suma += num;
            }
            this.lblsuma.Text = suma.ToString();
        }
    }
}
