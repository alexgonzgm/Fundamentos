using ProyectoClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Fundamentos
{
    public partial class SerializarColeccion : Form
    {
        XmlSerializer xmlSerializer;
        Productos productos;
        public SerializarColeccion()
        {
            InitializeComponent();
            this.xmlSerializer = new XmlSerializer(typeof(Productos));
            this.productos = new Productos(); 
          
        }

        private void btninsertarproducto_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            prod.Nombre = this.txtnombreproducto.Text;
            prod.Precio = int.Parse(this.txtprecio.Text);
            this.productos.Add(prod);
            this.PintarProductos();
            this.txtnombreproducto.Text = "";
            this.txtprecio.Text = "";
            this.txtnombreproducto.Focus();
            
        }

        private void PintarProductos()
        {
            this.lstproductos.Items.Clear();
            foreach (Producto product in this.productos)
            {
                this.lstproductos.Items.Add(product.Nombre);
            }
        }

        private void lstproductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstproductos.SelectedIndex != -1)
            {
                int indice = this.lstproductos.SelectedIndex;
                Producto prod = this.productos[indice];
                this.txtnombreproducto.Text = prod.Nombre;
                this.txtprecio.Text = prod.Precio.ToString();
            }
        }

        private  async void btnguardarproductos_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter("listaproductos.xml");
            this.xmlSerializer.Serialize(streamWriter, this.productos);
            await streamWriter.FlushAsync();
            streamWriter.Close();
            this.productos.Clear();
            this.lstproductos.Items.Clear();
        }

        private void btnleerproductos_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("listaproductos.xml");
            this.productos = (Productos)this.xmlSerializer.Deserialize(reader);
            reader.Close();
            this.PintarProductos();

        }

        private void txtnombreproducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
