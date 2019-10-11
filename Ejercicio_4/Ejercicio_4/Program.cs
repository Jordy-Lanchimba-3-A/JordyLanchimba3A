using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Horas = 0;
            int Total = 0;
            int Opcion = 0;
            do
            {
                Console.WriteLine("Ingrese las horas cumplidas del trabajador: ");
                Horas = Convert.ToInt32(Console.ReadLine());
                if (Horas <= 35)
                {
                    Total = Horas * 15;
                }
                else
                {
                    Total = ((35 * 15) + (Horas - 35) * 22);
                }
                Console.WriteLine("La cantidad que se le debe pagar es: {0}", Total);
                Console.WriteLine("¿Desea calcular otro salario?");
                Console.WriteLine("1 = Si");
                Console.WriteLine("2 = No");
                Opcion = Convert.ToInt32(Console.ReadLine());
            } while (Opcion == 1);
        }
    }
}
