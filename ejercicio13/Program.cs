using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dada una fecha mostrarla en el formato AAAAMMDD.*/

            DateTime anioMesDia = new DateTime(2024,08,30);

            Console.WriteLine(anioMesDia.ToString("yyyy/MM/dd"));

            Console.ReadKey();





        }
    }
}
