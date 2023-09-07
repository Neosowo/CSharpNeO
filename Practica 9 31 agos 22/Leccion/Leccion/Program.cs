using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lección
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XD i = new XD();
            i.ExerciseOne();
        }
    }
    public class XD
    {
        public void ExerciseOne()
        {
            //Programa que tenga, arreglo dinamico, nombres de aves y imprimir todos.
            Console.WriteLine("Ingrese el número de aves totales");
            int z = Convert.ToInt32(Console.ReadLine());
            string[] o = new string[z];
            int q = 0;
            while (q < o.Length)
            {
                int qww = q + 1; z++;
                Console.WriteLine("Ave número: " + qww);
                Console.WriteLine("Ingrese el nombre");
                o[q] = Console.ReadLine();
                q++;
            }
            int owo = z;
            int y = 0;
            Console.WriteLine("Salida: ");
            while (y < o.Length)
            {
                int qw = 0 + y; y++;
                int qaz = qw +1;
                Console.WriteLine(qaz + ".  " + o[qw]);
            }Console.ReadKey(true);
        }
    }

}