using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SystemNotes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ReadKey(true);
            Inicio i = new Inicio();
            Cursos c = new Cursos();
            Grados g = new Grados();
            busqueda b = new busqueda();
            i.preinicio();
        }
    }
    public class Inicio 
    {
        public void preinicio() 
        {
            Inicio i = new Inicio();
 
            Grados g = new Grados();
            busqueda b = new busqueda();
            Console.WriteLine("Ingrese la cantidad de estudiantes");
            int ctei = Convert.ToInt32(Console.ReadLine()); int zx = 0;
            while (ctei > zx) 
            {
                Console.WriteLine("Ingrese el codigo con el que quiere registar al estudiante");
                int[] code = new int[ctei];
                code[zx] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el nombre completo del estudiante");
                string[] namec = new string[ctei];
                namec[zx] = Console.ReadLine();
                int[] anio = new int[ctei];  int[] mes = new int[ctei]; int[] dia = new int[ctei];
                Console.WriteLine("Ingrese la fecha de nacimiento del estudiante" + "\nAño de nacimiento:");
                anio[zx] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mes de nacimiento:");
                mes[zx] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Día de nacimiento:");
                dia[zx] = Convert.ToInt32(Console.ReadLine());
                
                zx++;
            }
            int zq = 0;
            while(zq < ctei) 
            {
                Console.WriteLine("\n " + "¿Cuál es su curso?\nElige dependiendo el grado" + "\nMenu de grado" + "\n1. Primer grado\n2. Segundo grado\n3. Tercer grado\n4. Cuarto grado\n5. Quinto grado");
                string edg = Console.ReadLine();
                if (edg == "1")
                {
                    g.primerg();
                }
                else if (edg == "2")
                {
                    g.segundog();
                }
                else if (edg == "3")
                {
                    g.tercerg();
                }
                else if (edg == "4")
                {
                    g.cuartog();
                }
                else if (edg == "5")
                {
                    g.quintog();
                }
                else
                    while (edg != "1" + "2" + "3" + "4" + "5")
                    {
                        Console.WriteLine("Grado inexistente");
                        Console.WriteLine("\n " + "¿Cuál es el grado?\nElige dependiendo el grado" + "\nMenu de grado" + "\n1. Primer grado\n2. Segundo grado\n3. Tercer grado\n4. Cuarto grado\n5. Quinto grado");
                        string eedg = Console.ReadLine();
                        if (eedg == "1")
                        {
                            g.primerg();
                        }
                        else if (eedg == "2")
                        {
                            g.segundog();
                        }
                        else if (eedg == "3")
                        {
                            g.tercerg();
                        }
                        else if (eedg == "4")
                        {
                            g.cuartog();
                        }
                        else if (eedg == "5")
                        {
                            g.quintog();
                        }
                    }
                zq++;
            }


        }

    }
    public class Cursos
    {
        public void Matematicas()
        {
            Inicio i = new Inicio();
            Cursos c = new Cursos();
            Grados g = new Grados();
            busqueda b = new busqueda();
            Console.WriteLine("Ingresar 3 notas en matematicas");
            decimal [] notemates = new decimal[3];
            Console.WriteLine();

        }
        public void Fisica()
        {

        }
        public void Comunicacion()
        {

        }
        public void Arte()
        {

        }
        public void Historia()
        {

        }
    }

    public class Grados
    {
        public void primerg()
        {
            Inicio i = new Inicio();
            Cursos c = new Cursos();
            Grados g = new Grados();
            busqueda b = new busqueda();
            Console.WriteLine("\n " + "¿Cuál es el curso?\nElige dependiendo el grado" + "\nMenu de curso" + "\n1. Matemáticas\n2. Física\n3. Comunicación\n4. Arte\n5. Historia");
            string edc = Console.ReadLine();
            if (edc == "1")
            {
                c.Matematicas();
            }
            else if (edc == "2")
            {
                c.Fisica();
            }
            else if (edc == "3")
            {
                c.Comunicacion();
            }
            else if (edc == "4")
            {
                c.Arte();
            }
            else if (edc == "5")
            {
                c.Historia();
            }
        }
        public void segundog()
        {
            Inicio i = new Inicio();
            Grados g = new Grados();
            Cursos c = new Cursos();
            busqueda b = new busqueda();
            Console.WriteLine("\n " + "¿Cuál es el curso?\nElige dependiendo el grado" + "\nMenu de curso" + "\n1. Matemáticas\n2. Física\n3. Comunicación\n4. Arte\n5. Historia");
            string edc = Console.ReadLine();
            if (edc == "1")
            {
                c.Matematicas();
            }
            else if (edc == "2")
            {
                c.Fisica();
            }
            else if (edc == "3")
            {
                c.Comunicacion();
            }
            else if (edc == "4")
            {
                c.Arte();
            }
            else if (edc == "5")
            {
                c.Historia();
            }
        }
        public void tercerg()
        {
            Inicio i = new Inicio();
            Grados g = new Grados();
            Cursos c = new Cursos();
            busqueda b = new busqueda();
            Console.WriteLine("\n " + "¿Cuál es el curso?\nElige dependiendo el grado" + "\nMenu de curso" + "\n1. Matemáticas\n2. Física\n3. Comunicación\n4. Arte\n5. Historia");
            string edc = Console.ReadLine();
            if (edc == "1")
            {
                c.Matematicas();
            }
            else if (edc == "2")
            {
                c.Fisica();
            }
            else if (edc == "3")
            {
                c.Comunicacion();
            }
            else if (edc == "4")
            {

                c.Arte();
            }
            else if (edc == "5")
            {
                c.Historia();
            }
        }
        public void cuartog()
        {
            Inicio i = new Inicio();
            Cursos c = new Cursos();
            Grados g = new Grados();
            busqueda b = new busqueda();
            Console.WriteLine("\n " + "¿Cuál es el curso?\nElige dependiendo el grado" + "\nMenu de curso" + "\n1. Matemáticas\n2. Física\n3. Comunicación\n4. Arte\n5. Historia");
            string edc = Console.ReadLine();
            if (edc == "1")
            {
                c.Matematicas();
            }
            else if (edc == "2")
            {
                c.Fisica();
            }
            else if (edc == "3")
            {
                c.Comunicacion();
            }
            else if (edc == "4")
            {
                c.Arte();
            }
            else if (edc == "5")
            {
                c.Historia();
            }
        }
        public void quintog()
        {
            Inicio i = new Inicio();
            Cursos c = new Cursos();
            Grados g = new Grados();
            busqueda b = new busqueda();
            Console.WriteLine("\n " + "¿Cuál es el curso?\nElige dependiendo el grado" + "\nMenu de curso" + "\n1. Matemáticas\n2. Física\n3. Comunicación\n4. Arte\n5. Historia");
            string edc = Console.ReadLine();
            if (edc == "1")
            {
                c.Matematicas();
            }
            else if (edc == "2")
            {
                c.Fisica();
            }
            else if (edc == "3")
            {
                c.Comunicacion();
            }
            else if (edc == "4")
            {
                c.Arte();
            }
            else if (edc == "5")
            {
                c.Historia();
            }
        }

    }
    public class busqueda
    {
        public void tremendosifs()
        {
            Inicio i = new Inicio();

            Grados g = new Grados();
            busqueda b = new busqueda();
        }

    }
}
