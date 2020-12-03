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
    public partial class Form06DiaNacimientoSemana : Form
    {
        public Form06DiaNacimientoSemana()
        {
            InitializeComponent();
        }

        private void btnmostrardia_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(this.txtdia.Text);
            int mes = int.Parse(this.txtmes.Text);
            int anyo = int.Parse(this.txtanyo.Text);
            if (mes == 1)
            {
                mes = 13;
                //anyo--;
                //anyo = anyo - 1;
                anyo -= 1;
            }
            if (mes == 2)
            {
                mes = 14;
                anyo--;
            }
            int op1 = ((mes + 1) * 3) / 5;
            int op2 = anyo / 4;
            int op3 = anyo / 100;
            int op4 = anyo / 400;
            int op5 = dia + (mes * 2) + anyo + op1 + op2 - op3 + op4 + 2;
            int op6 = op5 / 7;
            int resultado = op5 - (op6 * 7);
            String diasemana = "";
            switch (resultado)
            {
                case 0:
                    diasemana = "SABADO";
                    break;
                case 1:
                    diasemana = "DOMINGO";
                    break;
                case 2:
                    diasemana = "LUNES";
                    break;
                case 3:
                    diasemana = "MARTES";
                    break;
                case 4:
                    diasemana = "MIERCOLES";
                    break;
                case 5:
                    diasemana = "JUEVES";
                    break;
                case 6:
                    diasemana = "VIERNES";
                    break;
            }
            this.lblresultado.Text = diasemana;
        }
    }
}
