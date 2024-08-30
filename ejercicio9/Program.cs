using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dadas dos frases concatenarlas y mostrar el resultado. */

            string frase1, frase2, frasecompleta;

            Console.WriteLine("Ingrese una frase: ");
            frase1 = Console.ReadLine();

            Console.WriteLine("Ingrese otra frase: ");
            frase2 = Console.ReadLine();

            frasecompleta = frase1 + " " + frase2;

            Console.WriteLine($"La frase completa es: {frasecompleta}");

            Console.ReadKey();
        }
    }
}
