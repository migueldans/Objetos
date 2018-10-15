using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finanzas
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Finanzas f1 = new Finanzas();
            Console.WriteLine("5 dolares son " + f1.DolarsToEuros(5) + " euros");
            Console.WriteLine("5 euros son " + f1.EurosToDolars(5) + " dolares");
            Console.ReadLine();
           

            Finanzas f2 = new Finanzas(0.99);
            //f2.SetCambio(0.99); se pone aqui o sino despues de finanzas como está puesto
            Console.WriteLine("10 dolares son " + f2.DolarsToEuros(10) + " euros");
            Console.WriteLine("10 euros son " + f2.EurosToDolars(10) + " dolares");
            Console.ReadLine();
        }
    }
}
