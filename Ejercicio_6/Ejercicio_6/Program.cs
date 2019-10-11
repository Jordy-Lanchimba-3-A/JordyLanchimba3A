using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número entero para hacer un rombo:");
            int rombo = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= rombo; i++)
            {
                for (int j = 1; j <= rombo - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            for (int i = rombo - 1; i >= 1; i--)
            {
                for (int j = 1; j <= rombo - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
