using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso1
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangulo figura1 = new Rectangulo();

            figura1.SetLargo(4);
            figura1.SetAncho(5);

            Console.WriteLine(figura1.Diagonal());
            Console.ReadLine();

            Monedero Cuenta1 = new Monedero();
        }
    }
}
