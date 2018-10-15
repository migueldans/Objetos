using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Satelite
    {
        private double meridiano;
        private double paralelo;
        private double distancia_tierra;
        
        public Satelite(double m, double p, double d)
        {
            meridiano = m;
            paralelo = p;
            distancia_tierra = d;
        }

        public Satelite()
        {
            meridiano = paralelo = distancia_tierra = 0;
        }

        public void SetPosicion(double m, double p, double d)
        {
            meridiano = m;
            paralelo = p;
            distancia_tierra = d;
        }

        public void PrintPosicion()
        {
            Console.WriteLine("El satélite se encuentra en el paralelo " + paralelo + "Meridiano " + meridiano + " a una distancia de la tierra de "+distancia_tierra+"Kilómetros");
            Console.ReadLine();
        }

        public void VariaAltura(double des)
        {
            distancia_tierra = distancia_tierra + des;
        }
    
        public bool EnOrbita()
        {

            if (distancia_tierra > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void VariaPosicion(double variap, double variam)
        {
            
            meridiano = meridiano + variam;
            paralelo = paralelo + variap;

        }

    }

}
