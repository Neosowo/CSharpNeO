using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Secondclass x = new Secondclass();
            x.IMC();


        }


    }

    public class Secondclass
    {
        public void IMC()
        {
            Secondclass x = new Secondclass();
            Console.WriteLine("Programa hecho por Neo" + "Introduzca su peso en kg");
            double kg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca su altura en metros");
            double m = Convert.ToDouble(Console.ReadLine());
            double IMC = kg / (m * m);
            double srimc = Math.Round(IMC);
            Console.WriteLine(IMC); Console.ReadKey(true);
            if (IMC == 0)
            {
                Console.WriteLine("Su IMC es de 0?");

            }

            else if (IMC < 18.5)
            {
                Console.WriteLine("Su IMC es de " + IMC + " ,por lo que tiene bajo peso");
            }
            else if (IMC >= 18.5 && IMC <= 24.9)
            {
                Console.WriteLine("Su IMC es de " + IMC + " ,por lo que tiene un peso normal");
            }
            else if (IMC >= 25.0 && IMC <= 29.9)
            {
                Console.WriteLine("Su IMC es de " + IMC + " ,por lo que tiene sobre peso");
            }
            else if (IMC >= 30.0 && IMC <= 34.9)
            {
                Console.WriteLine("Su IMC es de " + IMC + " ,por lo que tiene obesidad tipo I");
            }
            else if (IMC >= 35.0 && IMC <= 39.9)
            {
                Console.WriteLine("Su IMC es de " + IMC + " ,por lo que tiene obesidad tipo II");

            }
            else if (IMC > 40.0)
            {
                Console.WriteLine("Su IMC es de " + IMC + " ,por lo que tiene obesidad tipo III");
            }
        }

        public void exit() 
        {
            Secondclass x = new Secondclass();
            Console.WriteLine("        Menu" +
                "1. Calcular otro IMC" + "2. Salir");
            string zx = Console.ReadLine();
            if (zx == "1")
            {
                Console.WriteLine("Redirigiendo a la calculadora de IMC");
                x.IMC();
            }
            else if (zx == "2")
            {
                Console.WriteLine("Saliendo del programa...");
                Thread.Sleep(10);
                Thread.Exit(10);
            }
        }
    }
}''ñp