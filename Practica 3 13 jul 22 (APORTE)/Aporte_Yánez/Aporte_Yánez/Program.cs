using System;

namespace Aporte_Yánez
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x;
            decimal y;
            Console.WriteLine("PROGRAMA HECHO POR ERICK YANEZ");
            Console.WriteLine("Hacer un programa que pida usuario y contraseña, si es correcto mostrar Ingreso Correcto!, luego mostrar un menu con operaciones basicas, y que eliga el usuario");
            Console.WriteLine(" ");
            Console.WriteLine("Ingrese un usuario predeterminado");
            string usuariop = Console.ReadLine();
            Console.WriteLine("Ingrese una contraseña predeterminada");
            string passwordp = Console.ReadLine();
            Console.WriteLine("Ingrese usuario");
            string usuario = Console.ReadLine();
            Console.WriteLine("Ingrese contraseña");
            string password = Console.ReadLine();
            if (usuariop == usuario && passwordp == password)
            {
                Console.WriteLine("Ingreso correcto!");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Introduzca el primer número");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduzca el segundo número");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine("MENU DE OPERACIONES");
                Console.WriteLine(" ");
                Console.WriteLine("Si quiere sumar ingrese  sum");
                Console.WriteLine("Si quiere restar ingrese  res");
                Console.WriteLine("Si quiere multiplicar ingrese  mul");
                Console.WriteLine("Si quiere dividir ingrese  div");
                Console.WriteLine(" ");
                Console.WriteLine("Introduzca que quiere realizar:");
                string op = Console.ReadLine();
                if (op == "sum")
                {
                    Console.WriteLine(x + y);
                    Console.WriteLine("Operación exitosa! :D");
                }

                if (op == "res")
                {
                    Console.WriteLine(x - y);
                    Console.WriteLine("Operación exitosa! :D");

                }
                if (op == "mul")
                {
                    Console.WriteLine(x * y);
                    Console.WriteLine("Operación exitosa! :D");

                }
                if (op == "div")
                {

                    Console.WriteLine(x / y);
                    Console.WriteLine("Operación exitosa! :D");

                }

                else if (op != "sum" && op != "res" && op != "mul" && op != "div")
                {
                    Console.WriteLine("ERROR D:");
                }

            }
            else
            {
                Console.WriteLine("Ingreso incorrecto! D:");
                Console.WriteLine("Su usuario o contraseña es incorrecto, ingrese de nuevo!");
            }


            Console.WriteLine("ERICK YANEZ 1BGU INFORMATICA");
            Console.ReadKey(true);

        }
    }
}
