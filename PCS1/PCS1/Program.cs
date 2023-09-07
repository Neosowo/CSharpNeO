using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Crear 3 variables numericas con el valor que tu quieras
            y otra varuable numerica guardar el valor de la suma de las 3 anteriores.*/
            float a;
            float b;
            float c;
            float sum;
            a = 1;
            b = 2;
            c = 3;
            sum = a + b + c;
            Console.WriteLine(sum);
            Console.ReadKey(true);

            //Que pida un nombre y que lo junte con una frase
            Console.WriteLine("Tu nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine(nombre + " eres imbecil");
            Console.ReadKey(true);

            //Doxxeo :v
            int erq;
            Console.WriteLine("Escriba su nombre");
            string name = Console.ReadLine();
            Console.WriteLine("¿En que año nacio?");
            int edad = Console.Read();
            Console.WriteLine("¿Cuanto mide de alto usted?");
            float alto = Console.Read();
            erq = 2022 - edad;
            Console.WriteLine("Hola te he dociado uwu, aqui sus datos");
            Console.WriteLine("Tu nombre es " + name + " y naciste en el año " + edad + " Por lo tanto tienes " + erq + " y mides " + alto);
            Console.ReadKey(true);
        }
    }
}
