using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche miCoche = new Coche();
            miCoche.SetMarca("Opel");
            miCoche.SetModelo("Kapitän");

            Coche miNoCoche = new Coche("Ford","Transit MkII");

            miCoche.InfoCoche();
            miNoCoche.InfoCoche();

            Consumo miConsumo = new Consumo();


            Consumo miOtroConsumo = new Consumo(456, 9, 160, "Gasolina 95");

            miConsumo.InfoConsumo();
            miOtroConsumo.InfoConsumo();

        }

    }
}
