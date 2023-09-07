namespace P.E.__G.N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float ECV;
            int ECF;
            int PVU;
            int UN;
            int CVU;
            int MCU;
            int PE;
            int PEE;
            float GN;


            Console.WriteLine("PUNTO DE EQUILIBRIO  -  GANANCIA NETA");
            Console.WriteLine("Ingrese la sumatoria de costo variable");
            ECV = Convert.Float(Console.ReadLine());
            Console.WriteLine("Ingrese la sumatoria de costo fijos");
            ECF = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el precio variable unitario");
            PVU = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad del producto");
            UN = Convert.ToInt32(Console.ReadLine());
            CVU = ECV / UN;
            MCU = PVU - CVU;
            PE = ECF / MCU;
            GN = (MCU * UN) - (PE * MCU);

            Console.WriteLine("COSTO VARIABLE UNITARIO: " + CVU);
            Console.WriteLine("MARGEN DE CONTRIBUCION UNITARIA: " + MCU);
            Console.WriteLine("PUNTO DE EQUILIBRIO: " + PE);
            Console.WriteLine("GANANCIA NETA: " + GN);
            Console.WriteLine(" ");
            Console.WriteLine("e m o t i s a");


            Console.ReadKey(true);


            /*
            PEE = decimal.Round(PE, 1);
            */



        }
    }
}
