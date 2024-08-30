using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {
        static int suma(int v1, int v2)
        {

            return v1 + v2;

        }


        static void Main(string[] args)
        {
<<<<<<< HEAD
            /*Dados dos valores ingresados por teclado mostrar la suma de ambos.*/
=======
>>>>>>> f728ac3146626a747c40d4de35946d97068ccd2a

            int n1, n2, total;
            Console.Write("Agrega un número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese nro 2: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            total = suma(n1, n2);

            Console.WriteLine($"La suma es: {total}");


            Console.ReadKey();


        }
    }
}
