using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Consumo
    {
        private double kms, litros, vmed;
        private string tipoCombustible;

        const double GASOLINA95 = 1.14;
        const double GASOLINA98 = 1.25;
        const double DIESEL = 1.04;
        
        public Consumo()
        {
            kms=30;
            litros = 23.5;
            vmed = 98;
            tipoCombustible = "Diesel";
        }

        public Consumo(double kms, double litros,double vmed, string tipoCombustible)
        {
            this.kms = kms;
            this.litros = litros;
            this.vmed = vmed;
            this.tipoCombustible = tipoCombustible;
        }

        public double GetTiempo()
        {
            return kms / vmed;
        }

        public double ConsumoMedio()
        {
            return (100 * litros) / kms;
        }

        public double ConsumoEuros()
        {
            switch(tipoCombustible.ToUpper())
            {
                case "GASOLINA95":
                    return GASOLINA95 * ConsumoMedio();

                case "GASOLINA98":
                    return GASOLINA98 * ConsumoMedio();

                case "DIESEL":
                    return DIESEL * ConsumoMedio();

                default:
                    Console.WriteLine("El tipo de combustible no es valido.");
                    Console.ReadLine();
                    return 0;
            }
        }

        public void InfoConsumo(Coche Coche)
        {
            Console.Write("El coche " + Coche.GetMarca()+ " " + Coche.GetModelo() );
            Console.WriteLine(" ha recorrido " +kms+" kms, ha consumido " + litros + " litros de " +tipoCombustible+" y su velocidad media es de " + vmed + " km/h");
            Console.WriteLine("El tiempo tardado en hacer el recorrido ha sido de " + GetTiempo() + " horas, su consumo medio es de " + ConsumoMedio() + " litros y su consumo es de " + ConsumoEuros() + " euros.");
            Console.ReadLine();
        }

    }
}
