using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class Program
    {
        static int Superficie(int v1, int v2)
        {
            return v1 * v2;
        }


        static void Main(string[] args)
        {

            /*Dados los datos necesarios de un Cuadrado calcular la superficie.*/

            int lado1;
            int Superf;

            Console.Write("Ingrese el lado del cuadrado: ");
            lado1 = Convert.ToInt32(Console.ReadLine());

            Superf = Superficie(lado1, lado1);


            Console.WriteLine($"La superficie del cuadrado es: {Superf}");


            Console.ReadKey();


        }
    }
}
