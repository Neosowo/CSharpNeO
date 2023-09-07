using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesMatematicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a;
            float b;
            float sum;
            float res;
            float mul;
            float div;
            a = 30;
            b = 30;
            sum = a + b;
            res = a - b;
            mul = a * b;
            div = a / b;
            Console.WriteLine(sum);
            Console.WriteLine(res);
            Console.WriteLine(mul);
            Console.WriteLine(div);
            Console.ReadKey(true);
        }
    }
}
