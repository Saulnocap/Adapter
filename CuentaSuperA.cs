using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Cuenta_SuperA : IMethod
    {
        private static List<Cuenta_SuperA> CuentaSuperA = new List<Cuenta_SuperA>();
        private int cuenta { get; set; }
        private double monto { get; set; }
        private double deposito { get; set; }
        private double retiro { get; set; } 
        private double balance { get; set; }
        private double porcentaje { get; set; }
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
            CuentaSuperA.Add(new Cuenta_SuperA { cuenta = cuenta, balance = balance });
        }

        public void Consultar()
        {
            Console.Write(" Numero de cuenta: ");
            vcuenta = int.Parse(Console.ReadLine());

            if (vcuenta == CuentaSuperA[cuenta].cuenta)
            {
                Console.WriteLine("\n ***** BALANCE DE SU CUENTA *****");
                Console.WriteLine($"El balance de su cuenta es de {CuentaSuperA[cuenta].balance}");
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

            if (vcuenta == CuentaSuperA[cuenta].cuenta)
            {
                Console.WriteLine("Ingrese su deposito");
                deposito = double.Parse(Console.ReadLine());
                CuentaSuperA[cuenta].balance += deposito;
                Console.WriteLine("\n ***** BALANCE DE SU CUENTA *****");
                Console.WriteLine($"El balance de su cuenta es de {CuentaSuperA[cuenta].balance}");
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
            if (vcuenta == CuentaSuperA[cuenta].cuenta)
            {
                Console.WriteLine("Cuanto desea retirar");
                retiro = double.Parse(Console.ReadLine());
                validar(retiro);
                if (validar(retiro) is true) 
                {
                    CuentaSuperA[cuenta].balance -= retiro;
                }
                else
                {
                    Console.WriteLine(" No se puede efectuar el retiro ");
                    Console.ReadLine(); 
                }
                balance = CuentaSuperA[cuenta].balance;
                Console.WriteLine("\n ***** BALANCE DE SU CUENTA *****");
                Console.WriteLine($"El balance de su cuenta es de {CuentaSuperA[cuenta].balance}");
                Console.WriteLine(" Pulse cualquier boton para volver al menu");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(" No se encontro la cuenta ");
                Console.ReadKey();
            }

            
        }

        private bool validar(double sus)
        {
            balance = CuentaSuperA[cuenta].balance;
            porcentaje = balance * 0.4;
            if (sus < porcentaje)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void IterarList1()
        {
            if (CuentaSuperA.Count == 0)
            {
                Console.WriteLine("Ta' vacia");
            }
            else
            {
                Console.WriteLine("***** CUENTAS DE SUPERAHORRO *****");
                foreach (var cuentas in CuentaSuperA)
                {

                    Console.WriteLine($"Numero: {cuentas.cuenta}, Balance: {cuentas.balance}");

                }
            }
        }
    }
}
