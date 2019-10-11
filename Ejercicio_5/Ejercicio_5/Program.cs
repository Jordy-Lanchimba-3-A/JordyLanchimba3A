using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número entero para crear una piramide: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int j = 0, k = 0;
            for(int i = 1; i <= numero; i++)
            {
                for(j = 1; j <= (numero - i); j++)
                {
                    Console.Write(" ");
                }
                for(k = 1; k <= i; k++)
                {
                    Console.Write('*');
                }
                for(k = (i - 1); k >= 1; k--)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
