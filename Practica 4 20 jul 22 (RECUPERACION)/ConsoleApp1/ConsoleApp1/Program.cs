using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperación
{
    class Program// clase principal
    {
        static void Main(string[] args)// metodo principal
        {
            PYCT se = new PYCT();
            se.login();
            Console.ReadKey(true);
        }
    }
    public class PYCT
    {
        public void login()
        {
            PYCT se = new PYCT();

            string usuario, contrasenia;
            Console.WriteLine("Ingrese su usuario:");
            usuario = Console.ReadLine();
            Console.WriteLine("Ingrese su contrasenia:");
            contrasenia = Console.ReadLine();
            if ((usuario == "robles" && contrasenia == "uwu") || (usuario == "yupa" && contrasenia == "owo"))
            {
                Console.WriteLine("Usuario y contrasenia correctas \n Bienvenido al menu c:");
                se.menu();
            }

            else
            {

                Console.WriteLine("El usuario y contraseña no coinciden, numero de intentos disponibles: 2");
                Console.WriteLine("Ingrese su usuario:");
                usuario = Console.ReadLine();
                Console.WriteLine("Ingrese su contrasenia:");
                contrasenia = Console.ReadLine();
                if ((usuario == "robles" && contrasenia == "uwu") || (usuario == "yupa" && contrasenia == "owo"))
                {
                    Console.WriteLine("Usuario y contrasenia corractas \n Bienvenido al menu:");
                    se.menu();
                }
                else
                {
                    Console.WriteLine("El usuario y contraseña no coinciden, numero de intentos disponibles: 1");
                    Console.WriteLine("Ingrese su usuario:");
                    usuario = Console.ReadLine();
                    Console.WriteLine("Ingrese su contrasenia:");
                    contrasenia = Console.ReadLine();
                    if ((usuario == "robles" && contrasenia == "uwu") || (usuario == "yupa" && contrasenia == "owo"))
                    {
                        Console.WriteLine("Usuario y contrasenia corractas \nBienvenido al menu:");
                        se.menu();
                    }
                    else { Console.WriteLine("Numero de intentos: 0 \nIntentelo despues ;v."); Environment.Exit(0); }
                }
            }

        }
        public void menu()
        {
            PYCT se = new PYCT();
            Console.WriteLine("Escriba una de las siguientes opciones: \nsuma \nresta \nmultiplicacion \nDivision \nfibonaccie \nbubble sort \nserie del 2 ");
            string menu = Console.ReadLine();
            switch (menu)
            {
                case "suma":
                    string dato;
                    Double num1, num2, result;
                    Console.WriteLine("SUMA");
                    Console.WriteLine("Ingrese un numero entero o decimal: ");
                    dato = Console.ReadLine();
                    num1 = Convert.ToDouble(dato);

                    Console.WriteLine("Ingrese otro numero entero o decimal");
                    dato = Console.ReadLine();
                    num2 = Convert.ToDouble(dato);

                    result = num1 + num2;
                    Console.WriteLine("La suma es:" + result);
                    break;

                case "resta":
                    string data;
                    Double num3, num4, resultado;
                    Console.WriteLine("RESTA");
                    Console.WriteLine("Ingrese un numero entero o decimal: ");
                    data = Console.ReadLine();
                    num3 = Convert.ToDouble(data);

                    Console.WriteLine("Ingrese otro numero entero o decimal");
                    dato = Console.ReadLine();
                    num4 = Convert.ToDouble(data);

                    resultado = num3 - num4;
                    Console.WriteLine("La resta es:" + resultado);


                    break;

                case "multiplicacion":

                    Double num5, num6, Multipli;
                    Console.WriteLine("MULTIPLICACION");
                    Console.WriteLine("Ingrese un numero entero o decimal: ");
                    num5 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese otro numero entero o decimal");
                    num6 = Convert.ToDouble(Console.ReadLine());
                    Multipli = num5 * num6;
                    Console.WriteLine("La multiplicacion es:" + Multipli);



                    break;

                case "division":
                    Double num7, num8, Divi;
                    Console.WriteLine("MULTIPLICACION");
                    Console.WriteLine("Ingrese un numero entero o decimal: ");
                    num7 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese otro numero entero o decimal");
                    num8 = Convert.ToDouble(Console.ReadLine());
                    Divi = num7 / num8;
                    Console.WriteLine("La multiplicacion es:" + Divi);

                    break;

                case "fibonaccie":
                    int a, b, limite, auxiliar;
                    Console.WriteLine("Ingrese hasta que número desea mostrar en la serie de Fibonaccie:");
                    limite = int.Parse(Console.ReadLine());
                    a = 0;
                    b = 1;
                    for (; a <= limite;)
                    {
                        auxiliar = a;
                        a = b;
                        b = auxiliar + a;
                        Console.WriteLine(a);
                    }

                    break;

                case "bubble sort":
                    Console.WriteLine("Metodo de ordenamiento burbuja");

                    int I = 0;
                    int K = 0;
                    int CAN = 0;
                    int AUX = 0;

                    Console.WriteLine("Ingrese 10 numeros");
                    CAN = Convert.ToInt32(Console.ReadLine());
                    int[] VEC = new int[CAN + 1];
                    for (I = 0; I <= CAN; I++)
                    {
                        Console.WriteLine("ingresar la posicion{o} del arreglo" + I);
                        VEC[I] = Convert.ToInt32(Console.ReadLine());
                    }
                    for (I = 1; I <= CAN - 1; I++)
                    {
                        for (K = I + 1; K <= CAN; K++)
                        {
                            if (VEC[I] < VEC[K])
                            {
                                AUX = VEC[K];
                                VEC[K] = VEC[I];
                                VEC[I] = AUX;
                            }
                        }
                    }
                    Console.WriteLine();
                    for (I = 0; I <= CAN; I++)
                    {
                        Console.WriteLine(" " + VEC[I]);
                    }

                    break;

                case "serie del 2":

                    Console.WriteLine("Serie del 2");
                    for (int i = 0; i <= 50; i++)
                    {
                        Console.WriteLine(i * 2);
                    }
                    {
                        Console.ReadLine();

                        break;
                    }
            }
        }
    }

    public class practica2
    {
        public void ejercicio1()
        {
            string[] nombre = new string[5];
            int[] edad = new int[5];
            int anioactual = 0;
            Console.WriteLine("Ejercicio 1");
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Ingrese su mombre");
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Ingrese su anio de nacimiento");
                edad[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Ingrese el anio actual");
            anioactual = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Su nombre es {0} su edad es {1}", nombre[i], (anioactual - edad[i]));
            }
        }
        public void ejercicio2()
        {
            Console.WriteLine("Ejercicio 2");
            /*
             * Desarrollar un programa que pida 5 nombres, 5 anios de nacimiento
             * y que imprimia unicamente los registros de los de mayor de edad.
             */
            string[] nombre = new string[5];
            int[] edad = new int[5];
            int anioactual = 0;
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Ingrese su mombre");
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Ingrese su anio de nacimiento");
                edad[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Ingrese el anio actual");
            anioactual = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 4; i++)
            {
                if (edad[i] <= 2003)
                {
                    Console.WriteLine("Personas mayores de edad. \n Su nombre es {0} su edad es {1}", nombre[i], (anioactual - edad[i]));
                }
                else
                {
                    Console.WriteLine("\n\nPersonas menores de edad. \n Su nombre es {0} su edad es {1}", nombre[i], (anioactual - edad[i]));
                }
            }
        }
        public void ejercicio3()
        {
            Console.WriteLine("Ejercicio 3");
        }
        public void menu()
        {//  backSlash alt + 92 = \
            Console.WriteLine("Elija una de las siguientes opciones. " +
                "\n1.- Ejercicio 1" +
                "\n2.- Ejercicio 2" +
                "\n3.- Ejercicio 3 ");
            practica2 x = new practica2();
            string op = Console.ReadLine();
            switch (op)
            {
                case "1":
                    x.ejercicio1();
                    break;
                case "2":
                    x.ejercicio2();
                    break;
                case "3":
                    x.ejercicio3();
                    break;
                default:
                    Console.WriteLine("Elija una opcion valida del menú");
                    x.menu();
                    break;
            }
        }

    }
}