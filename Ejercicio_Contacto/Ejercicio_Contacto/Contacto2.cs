using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CONTACTO
{
    class Contacto2
    {
        //ATB
        private string nombre, tipoCon;
        private int telf;
        private DateTime fechaNac;
        private static int contCont, contFam, contAm, contTra, contEs;

        // CONSTRUCTOR POR DEFECTO
        public Contacto2()
        {
            
            this.fechaNac = fechaNac;
            this.telf = telf;
            this.nombre = nombre;
            this.tipoCon = tipoCon;
            contCont++;
        }
        public Contacto2(DateTime fechaNac, int telf, string nombre)
        {
            
            this.fechaNac = fechaNac;
            this.telf = telf;
            this.nombre = nombre;
            this.tipoCon = "Amigos";
            contCont++;
            contAm++;
        }
        public Contacto2(DateTime fechaNac, int telf, string nombre, string tipoCon)
        {
            switch (tipoCon.ToUpper())
            {
                case "FAMILIA":
                    contFam++;
                    break;
                case "AMIGO":
                    contAm++;
                    break;
                case "TRABAJO":
                    contTra++;
                    break;
                case "ESTUDIO":
                    contEs++;
                    break;
            }
            this.fechaNac = fechaNac;
            this.telf = telf;
            this.nombre = nombre;
            this.tipoCon = tipoCon;
            contCont++;

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
        public int GetContCont()
        {
            return contCont;
        }
        public int GetContTra()
        {
            return contTra;
        }
        public int GetContFam()
        {
            return contFam;
        }
        public int GetContAm()
        {
            return contAm;
        }
        public int GetContEs()
        {
            return contEs;
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
            Console.WriteLine("Tipo de contacto: " + tipoCon);
            Console.ReadLine();
        }
        //metodos nuevos
        public void CambiarTipo(string introTipo) 
        {
            this.tipoCon = introTipo;
        }
        public string ObtenerTipo()
        {
            return tipoCon;
        }
    }
}