using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio8
{
    internal class Program
    {

        static void Main(string[] args)
        {

            /*Calcular el factorial de 6.*/
            int numero = 6;
            int valorFactorial = 1;


            for (int i = 1; i <= numero; i++) 
            {
                valorFactorial = valorFactorial * i;
            }



            Console.WriteLine($"El factoral de {numero} es {valorFactorial}");
            Console.ReadKey();


            
        }
    }
}
