using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cronometro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s, m, h, d;
            s = 100;
            Console.WriteLine("cuantos segundos");
            int n = Convert.ToInt32(Console.ReadLine());
            while (s < n)
            {
                Thread.Sleep(1000);
                s++;
                Console.WriteLine(" ");
                Console.WriteLine("Segundos: " + s);
                if (s > 60)
                {
                    double ms = s / 60;
                    m = (int)Math.Floor(ms);
                    Console.WriteLine("Minutos: " + m + "    Segundos: " + s);
                    if (m > 60)
                    {
                        double hs = m / 60;
                        h = (int)Math.Floor(hs);
                        Console.WriteLine("Horas: " + h + "    Minutos: " + m + "    Segundos: " + s);
                    }
                }

            }
            Console.ReadKey(true);

        }
    }
}
