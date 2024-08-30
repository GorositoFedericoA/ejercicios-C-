using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program
    {
        static int suma(int v1, int v2)
        {

            return v1 - v2;

        }


        static void Main(string[] args)
        {

            /*Desarrollar  una aplicación de consola que tomando 2 números informe cuantos números hay entre los dos.*/

            int n1, n2, total;
            Console.Write("Agrega un número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese nro 2: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            total = suma(n1, n2);

            Console.WriteLine($"La resta es: {total}");


            Console.ReadKey();


        }
    }
}