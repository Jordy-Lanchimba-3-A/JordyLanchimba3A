using System;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número para generar una tabla de multiplicación:");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            int i = 1;
            for (i = 1; i <= 15; i++)
            {
                Convert.ToInt32(numero);
                Console.WriteLine("{0} x {1} = {2}", numero, i, numero * i);
            }
            Console.ReadKey();
        }
    }
}
