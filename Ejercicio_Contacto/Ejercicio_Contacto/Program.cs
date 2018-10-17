using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CONTACTO
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacto2 personaA = new Contacto2(new DateTime(1990, 3, 6), 94123456, "Miren", "Amigos");
            Contacto2 personaB = new Contacto2(DateTime.Now, 931212123, "Jon", "Trabajo");
            Contacto2 personaC = new Contacto2(new DateTime(1995, 5, 5), 0, "Ane", "Familia");
            Contacto2 personaD = new Contacto2(new DateTime(1992, 2, 12), 944123321, "Julen", "Estudio");
            Contacto2 personaE = new Contacto2(new DateTime(1992, 6, 6), 0, "Jone");
            Contacto2 personaF = new Contacto2(new DateTime(1997, 7, 7), 0, "Mikel", "Familia");
            personaA.MostrarDatos();
            personaB.MostrarDatos();
            personaC.MostrarDatos();
            personaD.MostrarDatos();
            personaE.MostrarDatos();
            personaF.MostrarDatos();

            Console.ReadLine();
            //***************DE AQUI PARA ABAJO -->CLASE CONTACTO*********************
            //Contacto persona1 = new Contacto();
            //persona1.SetNombre("Miren");
            //persona1.SetTelf(944123456);
            //persona1.SetFechaNac(new DateTime(1990, 4, 2));
            //Contacto persona2 = new Contacto("Jon", 931212123);
            //Contacto persona3 = new Contacto("Ane", new DateTime(1995,10,16));
            //Contacto persona4 = new Contacto();
            //persona4.SetNombre("Julen");
            //persona4.SetTelf(944123321);
            //persona4.SetFechaNac(new DateTime(1992, 4, 2));
            //Console.WriteLine(fecha1.GetDia());
            //Console.ReadLine();
            //Console.WriteLine(persona1.ObtenerEdad());
            //Console.ReadLine();
            //persona1.MostrarDatos();
            //persona2.MostrarDatos();
            //persona3.MostrarDatos();
            //persona4.MostrarDatos();
            //Console.WriteLine(persona1.ObtenerEdad());
            //Console.WriteLine(persona2.ObtenerEdad());
            //Console.WriteLine(persona3.ObtenerEdad());
            //Console.WriteLine(persona4.ObtenerEdad());
            //Console.ReadLine();
            //persona1.FelicitarA();
            //persona2.FelicitarA();
            //persona3.FelicitarA();
            //persona4.FelicitarA();
            //*****************************************************************************************
        }
    }
}