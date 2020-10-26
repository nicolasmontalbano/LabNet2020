using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Logic logic = new Logic();

                Console.WriteLine("Ingrese el mensaje personalizado de la excepción");

                string myExc = Console.ReadLine();

                logic.GetException(myExc);

                //Console.WriteLine("Excepción: ");
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Presione una tecla para salir");

            Console.ReadKey();
        }
    }
}
