using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Saldaña_metodos_y_funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Taller x = new Taller();
            x.Login();
            Console.ReadKey(true);
        }
    }
    public class Taller
    {
        public void Login()
        {

            Taller x = new Taller();
            string usuario, contrasenia;
            Console.WriteLine("Ingrese el usuario:");
            usuario = Console.ReadLine();
            Console.WriteLine("Ingrese la contrasenia:");
            contrasenia = Console.ReadLine();

            while (usuario != "Justin" || contrasenia != "0306") 
            {
                Console.WriteLine("Usuario o contraseña incorrectos!");
                Console.WriteLine("Ingrese el usuario:");
                usuario = Console.ReadLine();
                Console.WriteLine("Ingrese la contrasenia:");
                contrasenia = Console.ReadLine();
            }
            
            if (usuario == "Justin" && contrasenia == "0306")
            {
                Console.WriteLine("Bienvenido Justin, elige alguna opción de las siguientes:");
                Console.WriteLine("Menu de operaciones\nIngrese eligiendo las opciones del 1 al 4\n1.-Suma \n2.-Factura \n3.-Serie del 2\n4.-Salir");
                int op = Convert.ToInt32(Console.ReadLine());
                if (op == 1)
                {
                    x.suma();
                }
                else if (op == 2)
                {
                    x.factura();
                }
                else if (op == 3)
                {
                    x.serie2();
                }
                else if (op == 4)
                {
                    x.salir();
                }
                else
                {
                    Console.WriteLine("Error! \nOpciones del 1 al 4");
                    x.Login();
                }
            }
        }

        public void suma()
        {
            Taller x = new Taller();
            Console.WriteLine("Ingrese dos numeros:");
            int z;
            int y;
            int res;
            z = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            res = z + y;
            Console.WriteLine("El resultado es:" + res);
            Console.ReadKey(true);
            Console.WriteLine(" ");
            Console.WriteLine("Elige las siguientes opciones: \n1.-Salir \n2.-Ir al inicio");
            string xd = Console.ReadLine();
            if (xd == "1") 
            {
                x.salir();
            }
            else if (xd == "2")
            {
                x.Login();
            }
            else
            {
                Console.WriteLine("Error! \nOpciones del 1 al 2");
            }

        }
        public void factura()
        {
            Taller x = new Taller();
            Console.WriteLine("Ingrese 3 nombres de productos");
            string s, d, f;
            s = Console.ReadLine();
            d = Console.ReadLine();
            f = Console.ReadLine();
            Console.WriteLine("Ingrese el valor de los productos");
            double p1, p2, p3, resultado, iva;
            p1 = Convert.ToDouble(Console.ReadLine());
            p2 = Convert.ToDouble(Console.ReadLine());
            p3 = Convert.ToDouble(Console.ReadLine());
            iva = (p1 + p2 + p3) * 0.12;
            resultado = (p1 + p2 + p3) + iva;
            Console.WriteLine("El resultado es" + resultado);
            Console.ReadKey(true);
            Console.WriteLine(" ");
            Console.WriteLine("Elige las siguientes opciones: \n1.-Salir \n2.-Ir al inicio");
            string xd = Console.ReadLine();
            if (xd == "1")
            {
                x.salir();
            }
            else if (xd == "2")
            {
                x.Login();
            }
            else
            {
                Console.WriteLine("Error! \nOpciones del 1 al 2");
            }


        }
        public void serie2()
        {
            Taller x = new Taller();
            Console.WriteLine("Número maximo de la serie del 2");
            int n = Convert.ToInt32(Console.ReadLine());
            int q = 0;
            while (q < n)
            {
                q = q + 2;
                Console.WriteLine(q);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Elige las siguientes opciones: \n1.-Salir \n2.-Ir al inicio");
            string xd = Console.ReadLine();
            if (xd == "1")
            {
                x.salir();
            }
            else if (xd == "2")
            {
                x.Login();
            }
            else
            {
                Console.WriteLine("Error! \nOpciones del 1 al 2");
            }
        }
        public void salir()
        {
            Taller x = new Taller();
            Console.WriteLine("Programa hecho por Justin Saldaña");
            Console.WriteLine("¿Esta seguro de salir?\n si o no");
            string exp = Console.ReadLine();
            if (exp == "no")
            {
                x.Login();
            }
            else if (exp == "si")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Error! \nEscribe si o no, no se aceptan otras respuestas!");
                x.salir();
            }
        }
    }
}

