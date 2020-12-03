using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    #region ENUMERACIONES
        
    public enum TipoGenero
    {
        Masculino = 0, Femenino = 1
    }

    public enum Paises
    {
        España = 0, Inglaterra = 1, Francia = 2, Argentina = 3
    }

    #endregion

    public class Persona
    {
        #region CONSTRUCTORES PERSONA
        public Persona()
        {
            Debug.WriteLine("Constructor Persona Vacío");
        }

        public Persona(int edad, String nombre, String ape)
        {
            Debug.WriteLine("Constructor Persona con cosas");
        }

        public Persona(String nombre, String apellidos)
        {
            Debug.WriteLine("Constructor PERSONA con parámetros");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }
        #endregion

        #region PROPIEDADES
        //TODO LO QUE PONGAMOS AQUI, PODEMOS
        //COLAPSAR Y DESPLEGAR
        //PROPIEDAD EXTENDIDA CON LA DIRECCION DE CASA
        private Direccion _Domicilio;
        public Direccion Domicilio
        {
            get { return this._Domicilio; }
            set { this._Domicilio = value; }
        }

        //HACEMOS UNA PROPIEDAD AUTOIMPLEMENTADA
        public Direccion DomicilioVacaciones { get; set; }


        private TipoGenero _Genero;
        public TipoGenero Genero
        {
            get { return this._Genero; }
            set { 
                //DEBEMOS CONTROLAR SIEMPRE LOS VALORES
                //DE LAS ENUMERACIONES PARA VER SI COINCIDEN
                //CON NUESTRAS OPCIONES
                if (value != TipoGenero.Femenino &&
                    value != TipoGenero.Masculino)
                {
                    throw new Exception("Rango de Generos no soportado");
                }
                this._Genero = value; 
            }
        }

        private Paises _Nacionalidad;
        public Paises Nacionalidad
        {
            get { return this._Nacionalidad; }
            set { this._Nacionalidad = value; }
        }

        //PROPIEDAD INDIZADA CONTIENE MULTIPLES ELEMENTOS
        //NECESITAMOS UN CAMPO PARA MANEJAR LA PROPIEDAD
        //YO QUIERO CREAR UNA PROPIEDAD QUE CONTENGA
        //ESPACIO PARA 5 DESCRIPCIONES DE LA PERSONA
        private String[] _Descripciones = new String[5];
        //UNA PROPIEDAD INDIZADA NO TIENE name
        //SE UTILIZA LA PALABRA this PARA CREARLA
        public String this[int indice]
        {
            get { return this._Descripciones[indice]; }
            set {
                this._Descripciones[indice] = value;
            }
        }

        //CAMPOS DE LA CLASE
        //UN CAMPO SUELE SER PRIVADO Y HERRAMIENTA PARA
        //LA CLASE (ES UNA VARIABLE)
        // MODIFICADORES DE ACCESO TIENE QUE VER CON
        // LA ENCAPSULACION.  public, private
        //public String Nombre;
        //public int Edad;
        //EN VISUAL STUDIO, NO SE CREAN CAMPOS ACCESIBLES,
        //SIEMPRE SE CREAN PROPIEDADES
        //UNA PROPIEDAD ES UN CAMPO, PERO CONTIENE UN CODIGO
        //DONDE NOS PERMITE PODER CONTROLAR ELEMENTOS (getter, setter)
        //SINTAXIS DE PROPIEDAD
        //PROPIEDADES SIEMPRE public
        //LA PROPIEDADES SIEMPRE TENDRAN UN CAMPO DE CONTROL
        //EL CAMPO SERA PRIVADO PARA LA CLASE Y SERA
        //EL ENCARGADO DE MANEJAR LA PROPIEDAD.
        //SI YO LO DESEO, ASIGNO EL CAMPO, SINO, NO LO HAGO.
        // LOS CAMPOS DE PROPIEDAD SE REPRESENTAN CON _Propiedad
        private String _Nombre;
        public String Nombre
        {
            get {
                //DEVOLVEMOS UN VALOR
                return this._Nombre;
            }
            set {
                //ESTABLECEMOS UN VALOR
                //CAMBIAMOS EL VALOR DE LA PROPIEDAD
                this._Nombre = value;
            }
        }

        private String _Apellidos;
        public String Apellidos
        {
            get { return this._Apellidos; }
            set { this._Apellidos = value; }
        }

        //CAMPO DE LA PROPIEDAD
        private int _Edad;
        public int Edad
        {
            get { return this._Edad; }
            set
            {
                //TENEMOS UN CODIGO PARA CONTROLAR LOS
                //VALORES ASIGNADOS A LA PROPIEDAD
                if (value < 0)
                {
                    //DAMOS UN VALOR POR DEFECTO Y EL PROGRAMADOR
                    //NO LO SABE.  NO LE DAMOS NINGUN TOQUE
                    //this._Edad = 0;
                    //throw new TipoException
                    //Clase base es Exception
                    throw new Exception("Edad negativa: " + value);
                }
                else
                {
                    this._Edad = value;
                }
            }
        }

        #endregion

        #region METODOS DE LA CLASE PERSONA

            //METODOS void Y METODOS return
            //METODOS CON PARAMETROS OPCIONALES
        public void MetodoParametrosOpcionales(int numero
                , int parametroopcional = 99)
        {

        }

        //SOBRECARGA DE UN METODO
        //UN METODO TIENE DIFERENTES FORMAS
        //CUANDO UN METODO TIENE DISTINTAS FORMAS, TIENE
        //DISTINTOS CODIGOS
        //EL METODO DEBE LLAMARSE IGUAL Y TENER DISTINTOS
        //PARAMETROS Y TIPOS
        public String GetNombreCompleto()
        {
            return this.Nombre + ", " + this.Apellidos;
        }

        public String GetNombreCompleto(bool ordenacion)
        {
            if (ordenacion == true)
            {
                return this.Apellidos + ", " + this.Nombre;
            }
            else
            {
                return this.GetNombreCompleto();
            }
        }

        public void GetNombreCompleto(int numero)
        {}

        public String GetNombreCompleto(int valor, int otro)
        {
            return this.GetNombreCompleto().ToUpper();
        }

        #endregion
    }
}
