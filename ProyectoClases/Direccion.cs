using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Direccion
    {
        #region CONSTRUCTOR DE DIRECCION
        public Direccion()
        {
            Debug.WriteLine("constructor dirección simple");
        }

        //MULTIPLES CONSTRUCTORES CON EL CONCEPTO DE POLIMORFISMO
        public Direccion(String calle, String ciudad)
        {
            //INICIAMOS LAS PROPIEDADES
            this.Calle = calle;
            this.Ciudad = ciudad;
            Debug.WriteLine("Constructor con dos parámetros");
        }
        public Direccion(String calle, String ciudad, int cp)
            :this(calle, ciudad)
        {
            this.CodigoPostal = cp;
            Debug.WriteLine("Constructor con tres parámetros");
        }
        #endregion

        //CUANDO NO DESEAMOS COMPROBAR VALORES DE 
        //LA PROPIEDAD, SE UTILIZAN PROPIEDADES
        //AUTOIMPLEMENTADAS
        //ES UNA PROPIEDAD QUE NO TENEMOS QUE
        //ESCRIBIR EL CAMPO, ESTA DENTRO DE LA DECLARACION
        public String Calle { get; set; }
        public String Ciudad { get; set; }
        public int CodigoPostal { get; set; }
    }
}
