using System;
<<<<<<< HEAD
=======
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> f728ac3146626a747c40d4de35946d97068ccd2a

namespace ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            /* Dada una frase cualquiera llamada x, 
             * mostrar como resultado una frase formada por la segunda mitad de x más la primer mitad de x. 
             * (usar el método substring)
             */

            string bienvenida = "Bienvenidos al lenguaje de programacion C#";
            string bienvenidaPrimeraMitad, bienvenidaSegundaMitad, bienvenidaAlReves;
            int cantidadCaracteres;

            cantidadCaracteres = bienvenida.Length;


            bienvenidaPrimeraMitad = bienvenida.Substring(0, 21);
            bienvenidaSegundaMitad = bienvenida.Substring(21, 21);

            bienvenidaAlReves = bienvenidaSegundaMitad + " " + bienvenidaPrimeraMitad;

            Console.WriteLine(bienvenidaAlReves);
=======


            string bienvenida = "Bienvenidos al lenguaje de programacion C#";
            string bienvenida2;


            bienvenida2 = bienvenida.Substring(5,10);

            Console.WriteLine(bienvenida2);
>>>>>>> f728ac3146626a747c40d4de35946d97068ccd2a

            Console.ReadKey();

        }
    }
}
