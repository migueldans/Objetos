using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Coche
    {
        private string modelo;
        private string marca;
                
        public Coche()
        {
            
        }
        public Coche(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }
        
        public String GetMarca()
        {
            return marca;
        }
        public void SetMarca(String marca)
        {
            this.marca = marca;
        }

        public String GetModelo()
        {
            return modelo;
        }
        public void SetModelo(String modelo)
        {
            this.modelo = modelo;
        }

        public void InfoCoche()
        {
            Console.WriteLine("Este coche es de la marca " + marca + " modelo " + modelo);
            Console.ReadLine();
        }
    }
   

       


    
}


