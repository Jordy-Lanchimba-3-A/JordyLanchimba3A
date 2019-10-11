using System;
using System.Linq;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los de números que desea comparar: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            int[] Numeros = new int[valor];
            for (int i = 0; i < valor; i++)
            {
                Numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            int Mayor = Numeros.Max();
            Console.WriteLine("El número mayor es: {0}", Mayor);
            Console.ReadKey();
        }
    }
}
