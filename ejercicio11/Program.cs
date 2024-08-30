using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dada una frase informar la cantidad de caracteres que tiene.*/

            string bienvenida = "Hola Mundo";
            int cantidadCaracteres = 0;

            cantidadCaracteres = bienvenida.Length;

            Console.WriteLine(cantidadCaracteres);

            Console.ReadKey();


        }
    }
}
