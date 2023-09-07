using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
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
            Console.WriteLine("Ingrese el número de personas a ingresar");
            int z = Convert.ToInt32(Console.ReadLine());
            string [] o = new string[z];
            int q = 0;
            while (q < o.Length) 
            {
                Console.WriteLine("Ingrese un nombre:");
                o[q] = Console.ReadLine();
                q++;
            }
            int owo = z;
            int  y = 0;
            Console.WriteLine("Salida: ");
            while (y<o.Length)
            {
                int qw = 0 + y; y++;
                Console.WriteLine(o[qw]);  
            }
            Console.ReadKey(true); 
            
        }
    }
    
}
