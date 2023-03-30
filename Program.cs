using System;

namespace Adapter
{
    class Program
    {
        /// SOLO SE PUEDE INGRESAR UNA PERSONA AL PROGRAMA, LA PRIMERA PERSONA INGRESADA SERA LA QUE PODRA REALIZAR
        /// LAS OPERACIONES, NO SUPE COMO HACER QUE SE PUDIERA HACER CON TODOS LOS AÑADIDOS A LA LISTA
        /// SOLO PUEDE CREAR UN USUARIO DE CADA TIPO (Cuenta Ahorro comun y Cuenta Super Ahorro)
        static void Main(string[] args)
        {

            LF opcion = new LF();
            Cuenta_Ahorro ns = new Cuenta_Ahorro();
            Cuenta_SuperA nf = new Cuenta_SuperA();

            Console.Clear();
            int op;
            Console.WriteLine("(1) Cuenta Ahorro    (2) Cuentas Super Ahorro    (3) Salir");
            op = int.Parse(Console.ReadLine());
            if (op == 1)
            {
                opcion.opcionA();
                
            }
            else if (op == 2)
            {
                opcion.opcionS();
            }
            else if(op == 3)
            {
                Console.Write(" S a l i e n d o . . . ");
                Console.ReadLine();
            }
            else if(op == 4)
            {
                ns.IterarList();
                Console.ReadLine();
            }
            else
            {
                nf.IterarList1();
                Console.ReadLine();
            }


            Main(args);
        }

    }
}

