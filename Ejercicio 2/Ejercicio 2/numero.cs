using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Numero
    {
        //Realiza una clase número que almacene un número entero y tenga las siguientes características:

        private int numero;


        //Constructor por defecto que inicializa a 0 el número interno.
        //Constructor que inicializa el número interno.

        public Numero()
        {
            this.numero = 0;
        }
        public Numero(int numero)
        {
            this.numero = numero;
        }
        
        //Método añade que permite sumarle un número al valor interno.
        //Método resta que resta un número al valor interno.
        //Método getValor.Devuelve el valor interno.

        public int Suma()
        {
            return numero++;
        }
        public int Resta ()
        {
            return numero--;
        }
        public int GetNumero()
        {
            return numero;
        }

        //Método getDoble. Devuelve el doble del valor interno.
        //Método getTriple.Devuelve el triple del valor interno.
        //Método setNumero. Inicializa de nuevo el valor interno.

        public int GetDoble()
        {
            return  numero*2;
        }
        public int GetTriple()
        {
            return numero*3;
        }
        public int SetNumero(int numero)
        {
            return this.numero = numero;
        }
      
    }
}
