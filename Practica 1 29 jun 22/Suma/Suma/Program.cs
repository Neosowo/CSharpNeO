using System;

namespace Suma
{
    class Program
    {
        static void Main(string[] args)
        {
            Suma s = new Suma();
            s.suma();
        }
    }
    public class Suma
    {
        public void suma()
        {
            int a, b, res;
            a = 4;
            b = 5;
            res = a + b;
            Console.WriteLine(res);
            Console.ReadKey(true);
        }
    }
}
