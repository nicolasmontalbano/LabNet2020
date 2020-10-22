using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Avion : Transporte
    {
        #region Constructor
        public Avion(int pasajeros) : base(pasajeros)
        {
            Console.WriteLine("Soy un avion con {0} pasajeros", pasajeros);
        }
        #endregion

        #region Metodos publicos
        public override string Avanzar()
        {
            return base.Avanzar() + " como avion";
        }
        
        public override string Detenerse()
        {
            return base.Detenerse() + " como avion";
        }
        #endregion


    }
}
