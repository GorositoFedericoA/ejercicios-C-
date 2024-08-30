using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Mostrar la fecha y hora actual.*/

            DateTime diadehoy;


            diadehoy = DateTime.UtcNow;


            Console.WriteLine(diadehoy);

            Console.ReadKey();

        }
    }
}
