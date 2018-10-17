using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTACTO
{
    class CFecha
    {
        //ATB
        private DateTime fecha;

        //CONSTRUCTOR POR DEFECTO
        public CFecha()
        {
            this.fecha = new DateTime(2017, 12, 12);
        }
        ////CONSTRUCTOR
        //public CFecha(int introD, int introM, int introA)
        //{

        //}
        //GETTERS Y SETTERS
        public int GetDia()
        {
            return Convert.ToInt32(fecha.ToString("dd"));
        }
        public int GetMonth()
        {
            return Convert.ToInt32(fecha.ToString("MM"));
        }
        public int GetYear()
        {
            return Convert.ToInt32(fecha.ToString("yyyy"));
        }

    }
}