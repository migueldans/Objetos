using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double millasMarinas = 45;

            Millas m1 = new Millas(millasMarinas);
            m1.MillasAMetros();
            m1.MillasAKilometros();
            Console.WriteLine(m1.MillasAMetros() + " , " + m1.MillasAKilometros());
            Console.ReadLine();
        }
    }
}
