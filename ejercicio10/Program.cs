using System;

namespace ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            Console.ReadKey();

        }
    }
}
