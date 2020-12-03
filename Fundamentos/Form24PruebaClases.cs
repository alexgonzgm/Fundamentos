using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;

namespace Fundamentos
{
    public partial class Form24PruebaClases : Form
    {
        public Form24PruebaClases()
        {
            InitializeComponent();
        }

        private void btncrearpersona_Click(object sender, EventArgs e)
        {
            this.lstdatos.Items.Clear();
            //TODA CLASE DEBEMOS INSTANCIARLA
            Persona person = new Persona();
            person.Nombre = "Adrian";
            person.Edad = 18;
            person[0] = "Ojos claros";
            person[1] = "Mandibula cuadrada";
            person.Genero = TipoGenero.Masculino; //Son números 0|1
            person.Nacionalidad = Paises.Francia; //España, Inglaterra, Francia
            this.lstdatos.Items.Add("Nombre: " + person.Nombre);
            this.lstdatos.Items.Add("Edad: " + person.Edad);
            this.lstdatos.Items.Add("Genero: " + person.Genero);
            this.lstdatos.Items.Add("Nacionalidad: " + person.Nacionalidad);
            this.lstdatos.Items.Add("Descripción 0: " + person[0]);
            this.lstdatos.Items.Add("Descripción 1: " + person[1]);
            this.lstdatos.Items.Add("Nombre Completo: "
                + person.GetNombreCompleto(true));
            person.Domicilio = new Direccion();
            //person.Domicilio.Calle = "Calle Pez";
            this.lstdatos.Items.Add("Casa: " + person.Domicilio.Calle);
            person.DomicilioVacaciones = 
                new Direccion("Calle Canarias", "Alicante", 03195);
            //person.DomicilioVacaciones.Ciudad = "Marina Door";
            this.lstdatos.Items.Add("Vacaciones: " +
                person.DomicilioVacaciones.Ciudad);
        }

        private void btncrearempleado_Click(object sender, EventArgs e)
        {
            this.lstdatos.Items.Clear();
            Empleado emp = new Empleado();
            emp.Nombre = "Empleado";
            emp.Apellidos = "Apellidos emp";
            this.lstdatos.Items.Add("Datos completos: "
                + emp.GetNombreCompleto());
            Director dire = new Director();
            this.lstdatos.Items.Add("Director: "
                + dire.GetSalarioMinimo());
            this.lstdatos.Items.Add("Empleado: "
                + emp.GetSalarioMinimo());
            //this.lstdatos.Items.Add("Vacaciones Empleado: "
            //    + emp.GetVacaciones());
            this.lstdatos.Items.Add("Vacaciones Director: "
                + dire.GetVacaciones());
        }
    }
}
