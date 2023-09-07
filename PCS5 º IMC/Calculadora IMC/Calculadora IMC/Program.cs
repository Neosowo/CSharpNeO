using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INICIO VAR
            string name; 

            int dv; 
            int kg, m, lb, pul, imc;


            //FIN VAR
            Console.WriteLine("¿Cual es su nombre?");
            name = Console.ReadLine();
            Console.WriteLine("De acuerdo " + name + ", este programa calcula el IMC");
            Console.WriteLine("Seleccione la unidad de medida que mas le interese ingresando su numero: ");
            Console.WriteLine("1.- Kilogramos y metros");
            Console.WriteLine("2.- Libras y pulgadas");
            dv = Convert.ToInt32(Console.ReadLine());
            if (dv == 1)
            {
                Console.WriteLine("Usted eligio kilogramos y metros.");
                Console.WriteLine("Ingrese el valor en kilogramos:");
                kg = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el valor en metros:");
                m = Convert.ToInt32(Console.ReadLine());
                imc = kg / ((m)*(m));
                Console.WriteLine(imc);
                if    (imc > 18.5)
                {
                    Console.WriteLine("Imc es mayor a 18.5");

                }

            }
            else if (dv == 2)
            {
                Console.WriteLine("Usted eligio libras y pulgadas.");
                Console.WriteLine("Ingrese el valor en libras:");
                lb = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el valor en pulgadas:");
                pul = Convert.ToInt32(Console.ReadLine());
                imc = (lb / ((pul)*(pul))) * 703;
                Console.WriteLine(imc);

            }
            Console.ReadKey(true);

        }
    }
}
