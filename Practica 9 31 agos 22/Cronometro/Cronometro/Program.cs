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
            s = 0;
            Console.WriteLine("cuantos segundos");
            int n = Convert.ToInt32(Console.ReadLine());
            while (s < n)
            {
                Thread.Sleep(1000);
                s++;
                Console.WriteLine("Segundos: " + s);
            }
            if (s == 60) 
            {
                m = s / 60;
                Console.WriteLine("Minutos" + m + "Segundos: " + s);
            }




            /*
            if (s == 60)
            {
                m = 0;
                while (m < 60)
                {
                    Thread.Sleep(60000);
                    s++;
                    m++;
                    Console.WriteLine("Minutos: " + m);
                }
                if (m == 60)
                {
                    h = 1;
                    while (h < 60)
                    {
                        Thread.Sleep(3600000);
                        
                        h++;
                        Console.WriteLine("Horas: " + h);
                    }
                }
            }*/
            Console.ReadKey(true);

        }
    }
}
