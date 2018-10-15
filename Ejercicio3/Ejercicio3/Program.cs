using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Satelite s1 = new Satelite(1000,1000,1000);
            Console.ReadLine();

           
            s1.VariaAltura(10);
            Console.ReadLine();

            
            if(s1.EnOrbita() ==true)
            {
                Console.WriteLine("En el espacio");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("En tierra");
                Console.ReadLine();
            }

            s1.VariaPosicion(20,30);
            Console.ReadLine();
            

            s1.PrintPosicion();

            

            


        }
    }
}
