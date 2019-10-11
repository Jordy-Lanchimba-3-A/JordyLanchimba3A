using System;


namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Producto = 0, Valor = 0, Acomulador = 0;
            do
            {
                Console.WriteLine("Ingrese cantidad vendida: ");
                Producto = Convert.ToInt32(Console.ReadLine());
                if (Producto != 0)
                {
                    Console.WriteLine("Ingrese el precio del producto: ");
                    Valor = Convert.ToInt32(Console.ReadLine());
                }
                Acomulador = Acomulador + (Valor * Producto);
            } while (Producto != 0);
            Console.WriteLine("El valor a pagar es: {0}", Acomulador);
            Console.ReadKey();
        }
    }
}
