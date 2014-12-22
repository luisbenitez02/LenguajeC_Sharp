using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_de_control_Ingreso_de_datos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un numero a comprar con 8");
            int num = Convert.ToInt32(Console.ReadLine());//OJOOO!!! lo convertimos en la misma linea!

            if (8 < num)
            {
                Console.WriteLine("Si, 8 es menor que " + num);
            }
            else if (8 > num)
            {
                Console.WriteLine("Si, 8 es mayor que " + num);
            }
            else
            {
                Console.WriteLine("nada, nada... Circulen que son iguales");
            }
//-----------------------------------------------------------------------------------------------------
            //-------Anidacion del if
            Console.WriteLine("");
            Console.WriteLine("Dime tu edad");
            byte edad = Convert.ToByte(Console.ReadLine());
            if (edad < 30)
            {
                Console.WriteLine("Eres joven...");
                if (edad <= 18)
                {
                    Console.WriteLine("Y apenas estas en la flor de la juventud");
                }
                else if (edad <= 25)
                {
                    Console.WriteLine("Que estas en los mejores años!");
                }
                else
                {
                    Console.WriteLine("sigue disfrutando");
                }
            } else{
                Console.WriteLine("No eres tan joven eh... Deberias empezar a cuidarte");
                if (edad > 35)
                {
                    Console.WriteLine("Ya cotizas para pension?");
                }
            }
            Console.ReadKey();
        }
    }
}
