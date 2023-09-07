using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ClaseSecundaria x = new ClaseSecundaria();
            x.Suma();
            x.Resta();
            x.Multiplicacion();
            x.Division();

        }
    }
    public class ClaseSecundaria
    {
        public void Suma()
        {
            Console.WriteLine("Metodo suma");
            Console.WriteLine("Ingrese dos números para la suma");
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine(c);
        }
        public void Resta()
        {
            Console.WriteLine("resta");
            Console.WriteLine("Ingrese dos números");
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = a - b;
            Console.WriteLine(c);
        }
        public void Multiplicacion()
        {
            Console.WriteLine("multiplicación");
            Console.WriteLine("Ingrese dos números");
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = a * b;
            Console.WriteLine(c);
        }
        public void Division()
        {
            Console.WriteLine("división");
            Console.WriteLine("Ingrese dos números");
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = a / b;
            Console.WriteLine(c);
            Console.ReadKey(true);
        }
    }
}

