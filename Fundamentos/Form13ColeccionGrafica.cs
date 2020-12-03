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
    public partial class Form13ColeccionGrafica : Form
    {
        public Form13ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            String elem = this.txtelemento.Text;
            //LA COLECCION DONDE VAMOS A INSERTAR
            //ES .Items
            //DEBEMOS AVERIGUAR EL TIPO DE ITEMS
            this.lstelementos.Items.Add(elem);
            this.txtelemento.SelectAll();
            this.txtelemento.Focus();
        }

        private void lstelementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblposicion.Text =
                "Posición: " + this.lstelementos.SelectedIndex;
            this.lblseleccionado.Text =
                "Seleccionado: " + this.lstelementos.SelectedItem;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            //ELIMINAMOS TODOS LOS ELEMENTOS DE LA COLECCION
            this.lstelementos.Items.Clear();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            //PARA ELIMINAR ELEMENTOS INDIVIDUALES
            //TENEMOS DOS METODOS DIFERENTES
            // .Remove (Objeto)
            // .RemoveAt (indice)
            int indice = this.lstelementos.SelectedIndex;
            this.lstelementos.Items.RemoveAt(indice);
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            int indice = this.lstelementos.SelectedIndex;
            String elem = this.txtelemento.Text;
            this.lstelementos.Items[indice] = elem;
        }
    }
}
