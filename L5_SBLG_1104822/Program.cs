using System;

namespace L5_SBLG_1104822
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroEntero;

            Console.WriteLine("EJERCICIO 1");
            Console.WriteLine("Ingrese un Nùmero Entero" );
            //"siguiente instruccion recibe y almacena numero"/

            numeroEntero = Convert.ToInt32(Console.ReadLine());

            if (numeroEntero > 0)
            {
                Console.WriteLine("Resultado : positivo");
            }
            else if (numeroEntero < 0)
            {
                Console.WriteLine("Resultado : negativo");
            }
            else if (numeroEntero == 0)
            {
                Console.WriteLine("Resultado : es igual a cero");

            }
            Console.ReadKey();
        }
    }
}
