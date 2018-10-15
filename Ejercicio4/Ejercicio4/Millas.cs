using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Millas
    {
        //Crea una clase con un método MillasAMetros() que toma como parámetro de entrada un valor en millas marinas y las convierte a metros.
        //Una vez tengas este método escribe otro MillasAKilometros() que realice la misma conversión, pero esta vez exprese el resultado en kilómetros.
        //Nota: 1 milla marina equivale a 1852 metros.

        private double millasMarinas;

        public Millas(double millasMarinas)
        {
            this.millasMarinas = millasMarinas;
        }

        public double MillasAMetros()
        {
             return millasMarinas * 1852;
        }

        public double MillasAKilometros()
        {
            return MillasAMetros() / 1000;
        }


    }
}
