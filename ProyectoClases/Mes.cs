using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Mes
    {
        public Mes() { }
        public Mes(String nombre, int maxima, int minima)
        {
            this.Nombre = nombre;
            this.Maxima = maxima;
            this.Minima = minima;
        }
        public String Nombre { get; set; }
        public int Maxima { get; set; }
        public int Minima { get; set; }

        public double GetMedia()
        {
            return (this.Maxima + this.Minima) / 2;
        }
    }
}
