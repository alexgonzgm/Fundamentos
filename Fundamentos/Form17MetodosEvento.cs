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
    public partial class Form17MetodosEvento : Form
    {
        public Form17MetodosEvento()
        {
            InitializeComponent();
        }

        private void lblraton_MouseHover(object sender
            , EventArgs e)
        {

        }

        private void lblraton_MouseMove(object sender
            , MouseEventArgs e)
        {
            this.lblraton.Text = "X: " + e.X
                + ", Y: " + e.Y;
        }

        private void txtsolonumeros_KeyPress(object sender
            , KeyPressEventArgs e)
        {
            //DESEAMOS INCLUIR LA TECLA DE BORRAR
            //LO QUE SI PODEMOS HACER ES RECUPERAR
            //EL CODIGO ASCII DE UNA TECLA
            // TENEMOS UNA ENUMERACION QUE NOS DEVUELVE
            // TODOS LOS CODIGOS DE ASCII
            //BACK --> 8
            char c = (char) 8;
            char teclaback = (char)Keys.Back;

            //e.KeyChar == '-'
            //e.KeyChar  --> char
            if (char.IsDigit(e.KeyChar) == false
                && e.KeyChar != teclaback)
            {
                e.Handled = true;
            }
        }

        private void txtsololetras_KeyPress(object sender
            , KeyPressEventArgs e)
        {
            char teclaback = (char)Keys.Back;
            if (char.IsLetter(e.KeyChar) == false
                && e.KeyChar != teclaback)
            {
                e.Handled = true;
            }
        }
    }
}
