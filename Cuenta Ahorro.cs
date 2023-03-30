using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Cuenta_Ahorro : IMethod
    {
        private static List<Cuenta_Ahorro> CuentaAhorro = new List<Cuenta_Ahorro>();

        private int cuenta { get; set; }
        private double monto { get; set; }
        private double deposito { get; set; }
        private double retiro { get; set; }
        private double balance { get; set; }
        private int vcuenta { get; set; }


        public void Apertura()
        {
            Console.WriteLine("Ingrese su numero de cuenta");
            cuenta = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su el monto de apertura");
            monto = double.Parse(Console.ReadLine());
            balance = monto;
            Console.WriteLine(" Pulse cualquier boton para volver al menu");
            Console.ReadLine();
            CuentaAhorro.Add(new Cuenta_Ahorro { cuenta = cuenta, balance = balance });
        }

        public void Consultar()
        {

            Console.Write(" Numero de cuenta: ");
            vcuenta = int.Parse(Console.ReadLine());

            if (vcuenta == CuentaAhorro[cuenta].cuenta)
            {
                Console.WriteLine("\n ***** BALANCE DE SU CUENTA *****");
                Console.WriteLine($"El balance de su cuenta es de {CuentaAhorro[cuenta].balance}");
                Console.WriteLine(" Pulse cualquier boton para volver al menu");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(" No se encontro la cuenta ");
                Console.ReadKey();
            }

        }

        public void Depositar()
        {

            Console.Write(" Numero de cuenta: ");
            vcuenta = int.Parse(Console.ReadLine());

            if (vcuenta == CuentaAhorro[cuenta].cuenta)
            {
                Console.WriteLine("Ingrese su deposito");
                deposito = double.Parse(Console.ReadLine());
                CuentaAhorro[cuenta].balance += deposito;
                Console.WriteLine("\n ***** BALANCE DE SU CUENTA *****");
                Console.WriteLine($"El balance de su cuenta es de {CuentaAhorro[cuenta].balance}");
                Console.WriteLine(" Pulse cualquier boton para volver al menu");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(" No se encontro la cuenta ");
                Console.ReadKey();
            }
            

        }

        public void Retirar()
        {

            Console.Write(" Numero de cuenta: ");
            vcuenta = int.Parse(Console.ReadLine());

            if (vcuenta == CuentaAhorro[cuenta].cuenta)
            {
                Console.WriteLine("Cuanto desea retirar");
                retiro = double.Parse(Console.ReadLine());
                CuentaAhorro[cuenta].balance -= retiro;
                Console.WriteLine("\n ***** BALANCE DE SU CUENTA *****");
                Console.WriteLine($"El balance de su cuenta es de {CuentaAhorro[cuenta].balance}");
                Console.WriteLine(" Pulse cualquier boton para volver al menu");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(" No se encontro la cuenta ");
                Console.ReadKey();
            }
            
        }

        public void IterarList()
        {
            if (CuentaAhorro.Count == 0)
            {
                Console.WriteLine("Ta' vacia");
            }
            else
            {
                Console.WriteLine("***** CUENTAS DE AHORRO *****");
                foreach (var cuentas in CuentaAhorro)
                {

                    Console.WriteLine($"Numero: {cuentas.cuenta}, Balance: {cuentas.balance}");

                }
            }

        }
    }

}
