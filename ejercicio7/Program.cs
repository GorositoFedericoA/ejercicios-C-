using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7
{
    internal class Program
    {

        static int conversor(int v1)
        {
            // 1 Kbyte = 1024 bytes
            //1 byte = 8 bits
            int bytes = v1 * 1024; 
            int bits = bytes * 8;

            return bits;
        }
        static void Main(string[] args)
        {

            /*Si 1Byte tiene 8 bits, desarrolle una solución programática 
             * que permita calcular cuántos bits hay en cualquier combinación de x KBytes. 
             * Explique cómo llegó a esa conclusión.*/

            int Kbyte, bits;

            Console.Write("Ingrese N Kbytes: ");
            Kbyte = Convert.ToInt32(Console.ReadLine());

            bits = conversor(Kbyte);

            Console.WriteLine($"La cantidad de bytes en {Kbyte} Kbytes es: {Kbyte * 1024}");
            Console.WriteLine($"La cantidad de bits en {Kbyte} Kbytes es: {bits}");

            Console.ReadKey();




        }
    }
}
