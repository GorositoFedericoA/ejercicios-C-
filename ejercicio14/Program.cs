using System;
<<<<<<< HEAD
=======
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> f728ac3146626a747c40d4de35946d97068ccd2a

namespace ejercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            /*Dadas dos fechas calcular la diferencia en días entre una y la otra.*/

            DateTime primerDiaDelMes = new DateTime(2024, 08, 01);
            DateTime ultimoDiaDelMes = new DateTime(2024, 08, 31);
            TimeSpan diferenciaDias;


            diferenciaDias = ultimoDiaDelMes - primerDiaDelMes;


            Console.WriteLine($"Entre el {primerDiaDelMes.ToString("dd/MM/yyyy")} y " +
                $"{ultimoDiaDelMes.ToString("dd/MM/yyyy")} hay {diferenciaDias.Days} dias de diferencia ");


            Console.ReadKey();


=======
>>>>>>> f728ac3146626a747c40d4de35946d97068ccd2a
        }
    }
}
