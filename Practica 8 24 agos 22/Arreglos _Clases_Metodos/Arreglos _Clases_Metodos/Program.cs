using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Arreglos__Clases_Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Practica con arreglos  | While && For |";
            SecuClass x = new SecuClass();
            x.N();
        }
    }

    public class SecuClass
    {//Erick Yánez
        /*
        public void Menuuwu()
        {
            SecuClass x = new SecuClass();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                              Menu de operaciones");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. - Arreglos con ciclo While \n2. - Arreglos con ciclo For \n3. - Salir");string sop = Console.ReadLine();
            if (sop == "1") 
            {
                Console.WriteLine("Ciclo while");
                x.Arreglos_While();
            }
            else if (sop == "2") 
            {
                Console.WriteLine("Ciclo for");
                x.Arreglos_For();
            }
            else if (sop == "3") 
            {
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Opciones del 1 al 3\n Redirigiendo al menu...");
                Thread.Sleep(800);
                x.Menuuwu();
            }
            Console.ReadKey(true);
        }
        
        public void Arreglos_While()
        {
            SecuClass x = new SecuClass();
            int[] xd = new int[10];
            int i = 0;
            Console.WriteLine("Ingrese hasta 10 números");
            while (i < xd.Length)
            {
                Console.WriteLine("Ingrese un número:");
                xd[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            Console.WriteLine("El primer número ingresado fue: " + xd[0]);
            Console.WriteLine("El ultimo número ingresado fue: " + xd[9]);
            Console.WriteLine(" ");
            Console.WriteLine("Regresando al menu...");
            Thread.Sleep(800);
            x.Menuuwu();
            Console.ReadKey(true);
        }
        public void Arreglos_For()
        {
            SecuClass x = new SecuClass();
            int[] xd = new int[10];
            Console.WriteLine("Ingrese hasta 10 números");
            for (int j = 0; j < xd.Length; j++)
            {
                Console.WriteLine("Ingrese un número:");
                xd[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("El primer número ingresado fue: " + xd[0]);
            Console.WriteLine("El ultimo número ingresado fue: " + xd[9]);
            Console.WriteLine(" ");
            Console.WriteLine("Regresando al menu...");
            Thread.Sleep(800);
            x.Menuuwu();
            Console.ReadKey(true);
        }
        */

        public void N()
        {
            Console.WriteLine("Ingrese cuantos quiere almacenar");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] costilla = new int[x];
            int qw = 0;
            while (qw < costilla.Length)
            {
                costilla[qw]= Convert.ToInt32(Console.ReadLine());
                qw++;
            }

            Console.WriteLine("Ingrese que dato quiere ver");
            int Asq = Convert.ToInt32(Console.ReadLine());
            int R = Asq - 1;
            Console.WriteLine(costilla[R]);
            
            
            int qqqqw = Convert.ToInt32(Console.ReadLine());

            /*int zx = 0;
            while (zx < costilla.Length)
            {
                Console.WriteLine("\n " + costilla[zx]);
                Console.ReadKey(true);
                zx++;
            }*/



        }



    }
    
}
