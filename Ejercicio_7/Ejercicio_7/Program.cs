using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Dos columnas de números en orden ascendente (1 : 100) y descendente (100 : 1):");
            int j = 100;
            for (int i = 1; i <= j; i++)
            {
                Console.Write(i);
                Console.Write("   ");
                Console.WriteLine((j + 1) - i);
            }
            Console.ReadKey();
        }
    }
}
