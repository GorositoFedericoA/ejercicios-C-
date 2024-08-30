using System;

namespace ejercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dadas dos fechas calcular la diferencia en días entre una y la otra.*/

            DateTime primerDiaDelMes = new DateTime(2024, 08, 01);
            DateTime ultimoDiaDelMes = new DateTime(2024, 08, 31);
            TimeSpan diferenciaDias;


            diferenciaDias = ultimoDiaDelMes - primerDiaDelMes;


            Console.WriteLine($"Entre el {primerDiaDelMes.ToString("dd/MM/yyyy")} y " +
                $"{ultimoDiaDelMes.ToString("dd/MM/yyyy")} hay {diferenciaDias.Days} dias de diferencia ");


            Console.ReadKey();


        }
    }
}
