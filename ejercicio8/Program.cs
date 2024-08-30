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
<<<<<<< HEAD

            /*Calcular el factorial de 6.*/
            int numero = 6;
            int valorFactorial = 1;

=======
            int numero;
            int valorFactorial = 1;

            Console.Write("Ingrese un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

>>>>>>> f728ac3146626a747c40d4de35946d97068ccd2a

            for (int i = 1; i <= numero; i++) 
            {
                valorFactorial = valorFactorial * i;
            }



            Console.WriteLine($"El factoral de {numero} es {valorFactorial}");
            Console.ReadKey();


            
        }
    }
}
