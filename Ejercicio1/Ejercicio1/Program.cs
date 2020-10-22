using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Transporte[] transportes = new Transporte[10];
          

            for(int i = 0; i < 5; i++)
            {
                transportes[i] = new Automovil(i);
            }

            for(int i = 5; i < 10; i++)
            {
                transportes[i] = new Avion(i);
            }

            Console.WriteLine("\nPresione una tecla para salir");
            Console.ReadKey();
        }
    }
}
