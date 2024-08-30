using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    internal class Program
    {
        static double Diametro(double v1)
        {

            double diametro = v1 / Math.PI;

            return diametro;
        }


        static void Main(string[] args)
        {

            double Circunferencia;
            double Diam;

            Console.Write("Ingrese la circunferencia del circulo: ");
            Circunferencia = Convert.ToDouble(Console.ReadLine());

            Diam = Diametro(Circunferencia);


            Console.WriteLine($"El diametro del cuadrado es: {Diam}");


            Console.ReadKey();


        }
    }
}