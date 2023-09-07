using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sin_nombre
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double x;
            string n;
            x = 1;
            n = Console.ReadLine();
            while (n != "TERMINE")
            {
                x = x + 1;
                Console.WriteLine(x);
                n = Console.ReadLine();
            }
            Console.ReadKey(true);
        }
    }
}
