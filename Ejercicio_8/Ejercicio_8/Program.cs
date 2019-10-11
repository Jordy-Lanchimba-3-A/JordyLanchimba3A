using System;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número entero para empezar el conteo:");
            int Num = Convert.ToInt32(Console.ReadLine());
            int Doble = 0, Triple = 0;
            Console.WriteLine(" ");
            for (int i = 1; i <= Num; i++)
            {
                
                Console.Write(i);
                Console.Write(" ");
                Doble = Doble + 2;
                if (Doble > Num)
                {
                    Console.Write("  ");
                }
                else
                {
                    Console.Write(Doble);
                }
                Console.Write("  ");
                Triple = Triple + 3;
                if (Triple > Num)
                {
                    Console.Write("  ");
                }
                else
                {
                    Console.Write(Triple);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
