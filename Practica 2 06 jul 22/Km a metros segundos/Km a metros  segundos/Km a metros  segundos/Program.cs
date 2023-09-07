using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Km_a_metros__segundos /*Este es el nombre de mi proyecto*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Desarrollar un programa que pida la velocidad en Km/h y devuelve transformado a metros/segundo*/
            int km; /*Defino como entero una variable km, osea los kilómetros*/
            double ms; /*Defino como decimal el ms*/
            double rp; /*Defino como decimal el rp osea la respuesta*/
            Console.WriteLine("Ingrese el valor en Kilómetros / hora");
            ms = 0.2778; /*Defino ms con 0.24 más de 4 decimales por que si no sale incorrecto*/
            km = Convert.ToInt32(Console.ReadLine()); /*No se puede operaciones matemáticas, así que se convierte*/
            rp = km * ms;
            Console.WriteLine("La velocidad en m/s es: " + rp + "m/s");  /*Muestro rp que es la multiplicación de de los kilómetros por metros por segundo*/
            Console.ReadKey(true); /*Detiene el proceso hasta que presiones alguna tecla*/

            // string XD = Console.ReadLine();
            /*Console.WriteLine(XD); Esto lo hice para saber si funcionaba el guardar datos de texto en una variable
            Console.ReadKey();*/

            // Esta es la fórmula = (km/h en m/s). Metro por segundo = km por hora/3.6 ≈ km por hora*0.2778
        }
    }
}
