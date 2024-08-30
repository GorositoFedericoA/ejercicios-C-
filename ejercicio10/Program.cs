using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string bienvenida = "Bienvenidos al lenguaje de programacion C#";
            string bienvenida2;


            bienvenida2 = bienvenida.Substring(5,10);

            Console.WriteLine(bienvenida2);

            Console.ReadKey();

        }
    }
}
