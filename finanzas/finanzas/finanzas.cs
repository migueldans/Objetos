using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finanzas
{
    class Finanzas
    {
        ////Realiza una clase finanzas que convierta dólares a euros y viceversa.
            
        //private double dinero;
        private double cambio;

        ////La clase tiene que tener:

        ////Un constructor finanzas() por defecto, el cual establecerá el cambio Dólar-Euro en 0.92 .

        ////Un constructor finanzas(double), el cual permitirá configurar el cambio dólar-euro.

        public Finanzas()
        {
              this.cambio = 0.92;
        }

        public Finanzas(double cambio)
        {
            this.cambio = cambio;
        }

        ////Codifica los métodos dolaresToEuros y eurosToDolares.

        //public double GetDinero()
        //{
        //    return dinero;
        //}

        //public void SetDinero(double dinero)
        //{
        //    this.dinero = dinero;
        //}

        public double GetCambio()
        {
            return cambio;
        }

        public void SetCambio(double cambio)
        {
            this.cambio = cambio;
        }


        public double DolarsToEuros(double cantidad)
        {
            return cantidad * cambio;
        }

        public double EurosToDolars(double cantidad)
        {
            return cantidad / cambio;
        }

        //Prueba que dicha clase funciona correctamente haciendo conversiones entre euros y dólares.




    }
}
