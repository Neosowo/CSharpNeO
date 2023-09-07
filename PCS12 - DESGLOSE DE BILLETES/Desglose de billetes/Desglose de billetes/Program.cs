using System.Linq;
using System.Text;

namespace DesgloseBilletes
{

    class Program
    {

        static void Main(string[] args)
        {
            int cant;
            int b500 = 0, b200 = 0, b100 = 0, b50 = 0, b20, b10, b5, b1 = 0;
            string linea;
            Console.WriteLine("Ingrese el monto por favor.");
            linea = Console.ReadLine();
            cant = int.Parse(linea);
            if (cant >= 500)
            {                       
                b500 = cant / 500;
                cant = cant - (b500 * 500);
                Console.WriteLine("Tienes {0} billetes de 500.", b500);
            }

            if (cant >= 200)
            {
                b200 = cant / 200;
                cant = cant - (b200 * 200);
                Console.WriteLine("Tienes {0} billetes de 200.", b200);
            }

            if (cant >= 100)
            {
                b100 = cant / 100;
                cant = cant - (b100 * 100);
                Console.WriteLine("Tienes {0} billetes de 100.", b100);
            }

            if (cant >= 50)
            {
                b50 = cant / 50;
                cant = cant - (b50 * 50);
                Console.WriteLine("tienes {0} billetes de 50.", b50);
            }

            if (cant >= 20)
            {
                b20 = cant / 20;
                cant = cant - (b20 * 20);
                Console.WriteLine("Tienes {0} billetes de 20.", b20);
            }

            if (cant >= 10)
            {
                b10 = cant / 10;
                cant = cant - (b10 * 10);
                Console.WriteLine("Tienes {0} billetes de 10.", b10);
            }
            if (cant >= 5)
            {
                b5 = cant / 5;
                cant = cant - (b5 * 5);
                Console.WriteLine("Tienes {0} billetes de 5.", b5);
            }
            if (cant >= 1)
            {
                b1 = cant / 1;
                cant = cant - (b1 * 1);
                Console.WriteLine("Tienes {0} billetes de 1.", b1);
            }

            Console.WriteLine("La cantidad total es: " + linea);

        }
    }
}