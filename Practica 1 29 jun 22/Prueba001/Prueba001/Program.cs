using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba001 /*Nombre del proyecto*/
{
    internal class Program /*Clase principal del proyecto*/ 
    {
        static void Main(string[] args)/*Metodo principal*/
        {/*
          Los comentarios y las cadenas pueden llevar simbolos
            , emojis y caracteres especiales
            , sin embargo los nombres de variables clases y 
            métodos se recomiendan no usar este tipo de caracteres
         */
            Console.WriteLine("Hola mi nombre es Erick Yánez"); /*ConsoleWriteLine sirve para hacer saltos de linea*/
            Console.Write("Hola mi nombre es Erick Yánez");/*ConsoleWrite Muestra algo por pantalla pero no hace saltos de linea*/
            Console.WriteLine("Hola mi nombre es Erick Yánez");
            /*Tipos de variables (int)
             Variable tipo entero
            Son todas las variables numéricas sin decimales.

             Variables tipo decimal(float, decimal, real)
            Son todas las variables comprendidas entre numeros enteros y decimal,
            diferenciandose por la cantidad de decimales que cada una de estas soporta.

             Variable tipo caracter(string)
            Son variables en las cuales solo se guardan caracteres o texto, sin importar si este
            caracter sea una letra, simbolo o un numeros por lo tanto no puedo hacer operaciones matemáticas*/
           
            Console.ReadKey(true); /*Sirve para que lea el teclado*/
            //Desarrollar un programa que muestre su nombre, y en dos variables
            //ingresando números muestre la suma de los mismos.

            Console.WriteLine("Erick José Yánez Santana");
            float x;
            float y;
            float respuesta;
            x = 5;
            y = 6;
            respuesta = x + y;
            Console.WriteLine(respuesta);
            Console.ReadKey(true); /*Leer teclado*/
            //Desarrollar un programa que calcule el area de un rectangulo
            //base y altura
            float b;
            float a;
            b = 15;
            a = 10;
            respuesta = b * a;
            Console.WriteLine(respuesta);
            Console.ReadKey(true);

        }
    }
}
