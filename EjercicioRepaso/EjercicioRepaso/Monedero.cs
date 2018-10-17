using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso1
{
    class Monedero
    {
        private double dinero;

        public Monedero()
        {
            
        }

        public Monedero(double dineroInicial)
        {
            this.dinero = dineroInicial;
        }

        public void SetDinero(double introDinero)
        {
            while(introDinero + dinero<0)
            {
                Console.WriteLine("No tienes tantos diners");
                Console.WriteLine("Puedes sacar hasta " + dinero);
                Console.WriteLine("Introduzca otra cantidad");
                introDinero = Convert.ToDouble(Console.ReadLine());
            }

            this.dinero = dinero + introDinero;
        }

        public double GetDinero()
        {
            return dinero;
        }


    }
}
