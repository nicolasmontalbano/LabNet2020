using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Logic logic = new Logic();

                Console.WriteLine("Excepción: ");

                logic.GetException();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);              
            }

            Console.WriteLine("Presione una tecla para salir");

            Console.ReadKey();
        }
    }
}
