using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter 
{
    class Adaptador : IMethod
    {
        Cuenta_SuperA Super = new Cuenta_SuperA();
      
        public void Apertura()
        {
            Super.Apertura();
        }

        public void Consultar()
        {
            Super.Consultar();
        }

        public void Depositar()
        {
            Super.Depositar();
        }

        public void Retirar()
        {
            Super.Retirar();
        }
    }
}
