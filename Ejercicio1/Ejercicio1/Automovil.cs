using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Automovil : Transporte
    {
        #region Constructor
        public Automovil(int pasajeros) : base(pasajeros)
        {
            Console.WriteLine("Soy un automóvil con {0} pasajeros", pasajeros);
        }
        #endregion

        #region Metodos publicos
        public override string Avanzar()
        {
            return base.Avanzar() + " como automovil";
        }

        public override string Detenerse()
        {
            return base.Detenerse() + " como automovil";
        }
        #endregion



    }
}
