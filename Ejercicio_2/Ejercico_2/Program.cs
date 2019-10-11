using System;

namespace Ejercico_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número entero para crear un cuadrado: ");
            int borde = Convert.ToInt32(Console.ReadLine());

            while (borde < 2)
            {
                Console.WriteLine("Ingrese un número que sea mayor a 2 para crear un cuadrado: ");
                borde = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 1; i <= borde; i++)
            {
                for (int j = 1; j <= borde; j++)
                {
                    if (i == 1 || i == borde ||
                        j == 1 || j == borde)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
