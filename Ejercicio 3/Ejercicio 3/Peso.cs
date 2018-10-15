using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Peso
    {
        private double peso,kg;
        private String medida;

        public Peso(double peso,string medida)
        {
            this.kg = GetKilos(peso, medida);
            
        }

        public double GetKilos(double peso, String medida)
        {
            switch (medida.ToUpper())
            {
                case LB:
                    return peso = peso * 0.453;
                    break;
                case 2:
                    if (medida == Li)
                    {
                        peso = peso * 14.59;
                    }
                    break;
                case 3:
                    if (medida == Oz)
                    {
                        peso = peso * 0.02835;
                    }
                    break;
                case 4:
                    if (medida == P)
                    {
                        peso = peso * 0.00155;
                    }
                    break;
                case 5:
                    if (medida == K)
                    {
                        peso = peso * 1;
                    }
                    break;
                case 6:
                    if (medida == G)
                    {
                        peso = peso * 0.001;
                    }
                    break;
                case 7:
                    if (medida == Q)
                    {
                        peso = peso * 43.3;
                    }
                    break;
                default:
                    Console.WriteLine("mal introducido");
                        con
                        return peso
                        
            }

        //private double kg;
        //private String medida;

        //public Peso()
        //{

        //}

        //public Peso(double peso, string tipo)
        //{
        //    this.kg = GetKilos(peso, tipo);

        //}

        //public double GetKg()
        //{
        //    return kg;
        //}
        //public void SetKg(double kg)
        //{
        //    this.kg = kg;
        //}

        //public String GetMedida()
        //{
        //    return medida;
        //}
        //public void SetMedida(string medida)
        //{
        //    this.medida = medida;
        //}

        //public double GetLibras()
        //{
        //    return GetKg() / 0.453;
        //}
        //public double GetLingotes()
        //{
        //    return GetKg() / 14.59;
        //}
        //public double GetKilos(double peso, String tipo)
        //{
        //    switch (tipo.ToUpper())
        //    {
        //        case "LB":
        //            return peso * 0.453;
        //            

        //        case "LI":
        //            return peso * 14.59;
        //            

        //        case "OZ":
        //            return peso * 0.2835;
        //            

        //        case "P":
        //            return peso * 0.00155;
        //            

        //        case "K":
        //            return peso;
        //            

        //        case "G":
        //            return peso * 1000;
        //            

        //        case "Q":
        //            return peso * 43.3;
        //            

        //        default:
        //            Console.WriteLine("La medida introducida es incorrecta");
        //            Console.ReadLine();
        //            return peso;
        //            
        //    }
        //}
        //public double GetPeso(string tipo)
        //{
        //    switch (tipo.ToUpper())
        //    {
        //        case "LB":
        //            return GetLibras();
        //            

        //        case "LI":
        //            return GetLingotes();
        //            

        //        case "OZ":
        //            return GetKg() / 0.2835;
        //            

        //        case "P":
        //            return GetKg() / 0.00155;
        //            

        //        case "K":
        //            return GetKg();
        //            

        //        case "G":
        //            return GetKg() * 1000;
        //            

        //        case "Q":
        //            return GetKg() / 43.3;
        //            

        //        default:
        //            Console.WriteLine("La medida introducida es incorrecta");
        //            Console.ReadLine();
        //            return kg;
        //            
        //    }
        //}

    }
    }
}
