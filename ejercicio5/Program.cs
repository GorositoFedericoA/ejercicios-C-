using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    internal class Program
    {
        static int Superficie(int v1, int v2)
        {
            return v1 * v2;
        }


        static void Main(string[] args)
        {

            int LadoA, LadoB;
            int Superf;

            Console.Write("Ingrese el lado A del cuadrado: ");
            LadoA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el lado B del cuadrado: ");
            LadoB = Convert.ToInt32(Console.ReadLine());

            Superf = Superficie(LadoA, LadoB);


            Console.WriteLine($"La superficie del cuadrado es: {Superf}");


            Console.ReadKey();


        }
    }
}
