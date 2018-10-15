using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int peso = 5;
            String tipo = "LB";
            Peso p1 = new Peso(peso, tipo);
            //Console.WriteLine(p1.GetPeso(p1.GetKg(), "lb"));
            Console.WriteLine(peso + " " + tipo + " = " + p1.GetKg() + "kg");
            Console.WriteLine(p1.GetKg() + "kg =" + p1.GetPeso("lb") + " libras");
            Console.ReadLine();
        }
    }
}
