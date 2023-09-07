using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Taller x = new Taller();
            x.Login();
        }
    }
    public class Taller
    {
        public void Login()
        {
            Taller x = new Taller();
            string user, name;
            string password;
            Console.WriteLine("Programa hecho por Erick Yánez");
            Console.WriteLine("¿Cuál es su nombre?");
            name = Console.ReadLine();
            user = "Erick"; password = "123";
            Console.WriteLine("Ingrese el usuario:"); user = Console.ReadLine(); Console.WriteLine("Ingrese la contraseña:"); password = Console.ReadLine();
            if (user == "Erick" && password == "123")
            {
                Console.WriteLine("Bienvenido/a " + name + ", elige alguna opción de las siguientes:");
                x.Menu();
            }
            else
            {
                while (user != "Erick" || password != "123")
                {
                    Console.WriteLine("Usuario o contraseña incorrectas");
                    Console.WriteLine("Ingrese el usuario");
                    user = Console.ReadLine();
                    Console.WriteLine("Ingrese la contraseña:");
                    password = Console.ReadLine();
                }
                if (user == "Erick" && password == "123")
                {
                    Console.WriteLine("Bienvenido/a " + name + ", elige alguna opción de las siguientes:");
                    x.Menu();
                }
            }
            Console.ReadKey(true);
        }
        public void Menu()
        {
            Taller x = new Taller();
            Console.WriteLine("Menu de operaciones\nIngrese eligiendo las opciones del 1 al 4\n1 .-Suma \n2 .-Factura \n3 .-Serie del 2\n4 .-Salir");
            int op = Convert.ToInt32(Console.ReadLine());
            if (op == 1)
            {
                x.Suma();
            }
            else if (op == 2)
            {
                x.Factura();
            }
            else if (op == 3)
            {
                x.Serie2();
            }
            else if (op == 4)
            {
                x.Exit();
            }
            else
            {
                Console.WriteLine("Error! \nElige del 1 al 4, redirigiendo al menu...");
                Thread.Sleep(800);
                x.Menu();
            }
        }
        public void Suma()
        {
            Taller x = new Taller();
            Console.WriteLine("Ingrese dos números para la suma de estos mismos");
            Console.WriteLine("Primer número:");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Segundo número:");
            double n2 = Convert.ToDouble(Console.ReadLine());
            double r = n1 + n2;
            Console.WriteLine("Suma: " + n1 + " + " + n2 + " =  " + r);
            Console.WriteLine(" ");
            Console.WriteLine("Elija entre las siguientes opciones: \n1.- Salir del programa \n2.- Regresar al menu de operaciones \n3.- Regresar al inicio");
            int sop = Convert.ToInt32(Console.ReadLine());
            if (sop == 1)
            {
                x.Exit();
            }
            else if (sop == 2)
            {
                x.Menu();
            }
            else if (sop == 3)
            {
                x.Login();
            }
            else
            {
                Console.WriteLine("Error! Elige del 1 al 3");
                Console.ReadKey(true);
            }
        }
        public void Factura()
        {
            Taller x = new Taller();
            string fop1, fop3, fop5;
            Console.WriteLine("Ingrese 3 nombres de productos y sus precios");
            Console.WriteLine("Nombre del primer producto:"); fop1 = Console.ReadLine(); Console.WriteLine("¿Cuál es su precio?"); double fop2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nombre del segundo producto:"); fop3 = Console.ReadLine(); Console.WriteLine("¿Cuál es su precio?"); double fop4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nombre del tercer producto:"); fop5 = Console.ReadLine(); Console.WriteLine("¿Cuál es su precio?"); double fop6 = Convert.ToDouble(Console.ReadLine());
            double ST = fop2 + fop4 + fop6;
            double iv = ST * 0.12;
            double iva = ST + iv;
            Console.WriteLine("El subtotal es de: " + ST);
            Console.WriteLine("El IVA es de: " + iv);
            Console.WriteLine("El total es de: " + iva);
            Console.WriteLine(" ");
            Console.WriteLine("Elija entre las siguientes opciones: \n1.- Salir del programa \n2.- Regresar al menu de operaciones \n3.- Regresar al inicio");
            int sop = Convert.ToInt32(Console.ReadLine());
            if (sop == 1)
            {
                x.Exit();
            }
            else if (sop == 2)
            {
                x.Menu();
            }
            else if (sop == 3)
            {
                x.Login();
            }
            else
            {
                Console.WriteLine("Error! Elige del 1 al 3");
                Console.ReadKey(true);
            }
        }
        public void Serie2()
        {
            Taller x = new Taller();
            Console.WriteLine("Serie del 2");
            Console.WriteLine("Hasta que número quiere hacer la serie del 2");
            int n = Convert.ToInt32(Console.ReadLine());
            int q = 0;
            while (q < n)
            {
                q = q + 2;
                Console.WriteLine(q);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Elija entre las siguientes opciones: \n1.- Salir del programa \n2.- Regresar al menu de operaciones \n3.- Regresar al inicio");
            int sop = Convert.ToInt32(Console.ReadLine());
            if (sop == 1)
            {
                x.Exit();
            }
            else if (sop == 2)
            {
                x.Menu();
            }
            else if (sop == 3)
            {
                x.Login();
            }
            else
            {
                Console.WriteLine("Error! Elige del 1 al 3");
                Console.ReadKey(true);
            }
        }
        public void Exit()
        {
            Taller x = new Taller();
            Console.WriteLine("Programa hecho por Erick Yánez");
            Console.WriteLine("¿Esta seguro de salir?\n si o no");
            string exp = Console.ReadLine();
            if (exp == "no")
            {
                Console.WriteLine("Ok, redirigiendo al principio...");
                Thread.Sleep(1300);
                x.Login();
            }
            else if (exp == "si")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Error! \nEscribe si o no, no se aceptan otras respuestas!");
                x.Exit();
            }

        }
    }
}                                                                       