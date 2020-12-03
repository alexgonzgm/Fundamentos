using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Empleado: Persona
    {
        #region CONSTRUCTORES EMPLEADO
        public Empleado()
            :base()
        {
            Debug.WriteLine("Constructor vacío Empleado");
            this.SalarioMinimo = 1500;
        }

        public Empleado(string nombre, string apellidos)
            :base(nombre, apellidos)
        {
            Debug.WriteLine("Constructor EMPLEADO con parámetros");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }
        #endregion

        #region PROPIEDADES DE EMPLEADO

        protected int SalarioMinimo { get; set; }

        #endregion

        #region METODOS CLASE EMPLEADO
        public int GetSalarioMinimo()
        {
            return this.SalarioMinimo;
        }
        
        public virtual int GetVacaciones()
        {
            Debug.WriteLine("GetVacaciones() de EMPLEADO");
            return 22;
        }
        #endregion
    }
}
