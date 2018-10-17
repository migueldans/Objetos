using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepaso1
{
    class Rectangulo
    {
        private int largo, ancho;

        public Rectangulo()
        {

        }

        public Rectangulo(int largo, int ancho)
        {
            this.largo = largo;
            this.ancho = ancho;
        }

        //Get & Set

        public int GetLargo()
        {
            return largo;
        }
        public void SetLargo(int introLargo)
        {
            this.largo = introLargo;
        }
        public int GetAncho()
        {
            return ancho;
        }
        public void SetAncho(int introAncho)
        {
            this.ancho = introAncho;
        }

        public int AreaRectangulo()
        {
            int areaRectangulo = ancho * largo;
            return areaRectangulo;
        }

        public double Diagonal()
        {
            double diagonal = Math.Sqrt(Math.Pow(ancho, 2) + Math.Pow(largo, 2));
            return diagonal;
        }


    }
}
