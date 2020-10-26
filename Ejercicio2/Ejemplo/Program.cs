using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Division division = new Division();
            try
            {
                Console.WriteLine("Ingrese el dividendo");

                int dividendo = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el divisor");

                int divisor = int.Parse(Console.ReadLine());

                Console.WriteLine(division.DivisionsExceptions(dividendo, divisor));

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"{ex.Message} \nTu amor por ella es como la división sobre cero: un error");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"{ex.Message} Tenes que ingresar numeros ");
            }

            Console.WriteLine("Fin de la operacion. Presione una tecla para salir");

            Console.ReadKey();
        }
    }
}
