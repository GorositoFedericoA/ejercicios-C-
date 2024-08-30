using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Program
    {
        static int perimetro(int v1,int v2,int v3)
        {
            return v1 + v2 + v3;
        }


        static void Main(string[] args)
        {
<<<<<<< HEAD
            /*Dados los lados de un triangulo calcular el perímetro.*/
=======

>>>>>>> f728ac3146626a747c40d4de35946d97068ccd2a
            int lado1, lado2, lado3 = 10;
            int peri;

            Console.Write("Ingrese el lado 1 del triangulo: ");
            lado1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el lado 2 del triangulo: ");
            lado2 = Convert.ToInt32(Console.ReadLine());

            peri = perimetro(lado1, lado2, lado3);


            Console.WriteLine($"El valor del lado 3 es: {lado3}");

            Console.WriteLine($"El perimetro del triangulo es: {peri}");


            Console.ReadKey();


        }
    }
}
