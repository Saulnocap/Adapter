using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class LF
    {
        Cuenta_Ahorro newcount = new Cuenta_Ahorro();
        Cuenta_SuperA newcount1 = new Cuenta_SuperA();
        Adaptador adp = new Adaptador();

        int op;
        public void opcionA()
        {
            Console.WriteLine(" < Que desea hacer > ");
            Console.WriteLine("(1) Abrir nueva cuenta de ahorro   (2) Depositar   (3) Retirar  (4) Consultar estado de la cuenta ");
            op = int.Parse(Console.ReadLine());
            if (op == 1)
            {
                newcount.Apertura();
            }
            else if (op == 2)
            {
                newcount.Depositar();
            }
            else if (op == 3)
            {
                newcount.Retirar();
            }
            else
            {
                newcount.Consultar();
            }
        }
        public void opcionS()
        {

            Console.WriteLine(" < Que desea hacer > ");
            Console.WriteLine("(1) Abrir nueva cuenta de ahorro   (2) Depositar   (3) Retirar  (4) Consultar estado de la cuenta ");
            op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                adp.Apertura();
            }
            else if (op == 2)
            {
                adp.Depositar();
            }
            else if (op == 3)
            {
                adp.Retirar();
            }
            else
            {
                adp.Consultar();
            }
        }
    }
}
