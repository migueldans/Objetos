using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CONTACTO
{
    class Contacto
    {
        //ATB
        private string nombre;
        private int telf;
        private DateTime fechaNac;
        // CONSTRUCTOR POR DEFECTO
        public Contacto()
        {
            this.fechaNac = fechaNac;
            this.telf = telf;
            this.nombre = nombre;
        }
        public Contacto(string introNom, DateTime introFechaNac)
        {
            this.nombre = introNom;
            this.fechaNac = introFechaNac;
            if (Convert.ToInt32(fechaNac.ToString("yyyy")) < 1900)
            {
                SetFechaNac(DateTime.Now);
            }

            //try
            //{
            //}catch(DataMisalignedException es)
            //{
            //    Console.WriteLine("El formato de la fecha es erróneo, FECHA: YYYY,MM,DD");
            //}

        }
        public Contacto(string introNom, int introTelf)
        {
            this.nombre = introNom;
            this.telf = introTelf;
        }
        //GETTERS Y SETTERS
        public string GetNombre()
        {
            return nombre;
        }
        public int GetTelf()
        {
            return telf;
        }
        public DateTime GetFechaNac()
        {
            return fechaNac;
        }
        public void SetNombre(string introNombre)
        {
            this.nombre = introNombre;
        }
        public void SetTelf(int introTelf)
        {
            this.telf = introTelf;
        }
        public void SetFechaNac(DateTime introFechaNac)
        {
            this.fechaNac = introFechaNac;
        }
        //METODOS
        public void CambiarNombre(string nombreN)
        {
            this.nombre = nombreN;
        }
        public string DevolverNombre()
        {
            return nombre;
        }
        public void CambiarTelf(int telfN)
        {
            this.telf = telfN;
        }
        public int DevolverTelf()
        {
            return telf;
        }
        public int ObtenerEdad()
        {
            TimeSpan ts = DateTime.Now - fechaNac;

            return ts.Days / 365;
        }
        public void FelicitarA()
        {
            string dia = DateTime.Now.ToString("dd");
            string month = DateTime.Now.ToString("MM");
            if (fechaNac.ToString("dd") == dia && fechaNac.ToString("MM") == month)
            {
                Console.WriteLine("¡FELICIDADEES! Has cumplido " + ObtenerEdad() + " años");
            }
            else
            {
                Console.WriteLine("Cri,cri");
            }
            Console.ReadLine();
        }
        public void MostrarDatos()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Teléfono: " + telf);
            Console.WriteLine("Fecha nacimiento: " + fechaNac);
            Console.ReadLine();
        }
    }
}