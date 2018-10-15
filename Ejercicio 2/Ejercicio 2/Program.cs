using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero n1 = new Numero();
            Console.WriteLine(n1.Suma()+ "," + n1.Resta() + "," + n1.GetNumero() + "," + n1.GetDoble() + "," + n1.GetTriple() + "," );
            Console.ReadLine();
            
            Numero n2 = new Numero(9);
            Console.WriteLine(n1.Suma() + "," + n1.Resta() + "," + n1.GetNumero() + "," + n1.GetDoble() +"," + n1.GetTriple() + "," );
            Console.ReadLine();
            
        }
    }
}
