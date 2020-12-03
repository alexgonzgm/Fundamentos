using ProyectoClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Fundamentos
{
    public partial class Form28SerializarClase : Form
    {
        XmlSerializer serial;

        public Form28SerializarClase()
        {
            InitializeComponent();
            //EN EL MOMENTO DE INSTANCIAR EL OBJETO
            //DEBEMOS INDICAR LA CLASE QUE ALMACENAREMOS
            // Type
            this.serial = new XmlSerializer(typeof(Producto));
        }

        private async void btnguardarproducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Nombre = this.txtnombreproducto.Text;
            producto.Precio = int.Parse(this.txtprecio.Text);
            //Para serializar se utiliza System.IO y la
            //clase Stream (Reader, Writer)
            StreamWriter writer = new StreamWriter("producto.xml");
            //CON EL METODO Serialize ALMACENAMOS UN OBJETO
            //DE LA CLASE Y GENERA UN FICHERO xml CON EL PRODUCTO
            //EL writer ES EL VEHICULO PARA ESCRIBIR EL FICHERO
            this.serial.Serialize(writer, producto);
            await writer.FlushAsync();
            writer.Close();
            this.txtnombreproducto.Text = "";
            this.txtprecio.Text = "";
            this.lblinfo.Text = "Datos guardados";
        }

        private void btnleerproducto_Click(object sender, EventArgs e)
        {
            StreamReader reader = 
                new StreamReader(@"producto.xml");

            //LA DESERIALIZACION ES AUTOMATICA
            //NOSOTROS ENVIAMOS EL READER Y NOS DEVUELVE
            //EL OBJETO YA INSTANCIADO
            //UTILIZAMOS EL METODO Deserialize
            Producto producto = (Producto)
                this.serial.Deserialize(reader);
            reader.Close();
            this.txtnombreproducto.Text = producto.Nombre;
            this.txtprecio.Text = producto.Precio.ToString();
            this.lblinfo.Text = "Producto leído";
        }
    }
}
