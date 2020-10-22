using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public abstract class Transporte
    {

        #region Atributos
        private int pasajeros;    
        #endregion

        #region Constructor
        public Transporte(int pasajeros)
        {
            this.pasajeros = pasajeros;
        }
        #endregion

        #region Metodos publicos
        public virtual string Avanzar()
        {
            return "Avanzo";
        }

        public virtual string Detenerse()
        {
            return "Me detengo";
        }
        #endregion


    }
}
