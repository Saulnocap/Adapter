using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    interface IMethod
    {
        void Apertura();
        void Depositar();
        void Retirar();
        void Consultar();

    }
}
