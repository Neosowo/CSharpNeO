using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace P.E.__G.N_ADV_EY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SCLass x = new SCLass();
            
        }
 
    } 
    public class SCLass
    {
        public void login()
        {
            SCLass x = new SCLass();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("            Calculador de PE - GN - FD");
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Ingrese usuario");
            string usuario = Console.ReadLine();
            Console.WriteLine("Ingrese contraseña");
            string password = Console.ReadLine();
            while (usuario != "qwert" || password != "123") ;
            {
                Console.WriteLine(" " + "\nUsuario o contraseña incorrectos!" + "\nIngrese usuario");
                usuario = Console.ReadLine();
                Console.WriteLine("Ingrese contraseña");
                password = Console.ReadLine();
            }
            if (usuario == "qwert" && password == "123")
            {
                x.menu();
            }
        }

        public void menu()
        {
            SCLass x = new SCLass();
            Console.WriteLine(" " + "\nBienvenid@ al menu" + "\nElige de acuerdo al número asignado");
            Console.WriteLine("1. - Punto de equilibrio \n2. - Flujo de dínero");
            string op = Console.ReadLine();
            Console.ReadKey(true);
        }

        public void pe_gn()
        {



        }

        
    }
}
//12H