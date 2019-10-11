using System;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {

                Console.WriteLine("\n Eleja una opción del siguiente menu: ");
                Console.WriteLine("1) Salir");
                Console.WriteLine("2) Sumatorio");
                Console.WriteLine("3) Factorial");
                Console.WriteLine(" ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        //Environment.Exit(0);
                        break;
                    case 2:
                        Console.WriteLine("Ingrese 2 números para la sumatoria: ");
                        int Valor1 = Convert.ToInt32(Console.ReadLine());
                        int Valor2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La respuesta de la sumatoria es: {0}", Valor1 + Valor2);
                        Console.WriteLine("Presione Enter para continuar: ");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Ingrese un número para calcular el factorial: ");
                        int Num = Convert.ToInt32(Console.ReadLine());
                        int Fac = Num;
                        for (int i = Num - 1; i >= 1; i--)
                        {
                            Fac = Fac * i;
                        }
                        Console.WriteLine("El factorial de {0} es {1}", Num, Fac);
                        Console.WriteLine("Precione Enter para continuar: ");
                        Console.ReadKey();
                        break;
                }
            }while (opcion != 1);
        }
    }
}
