using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 = 35;
            int var2 = 45;

            int var3 = 4;
            int var4 = 25;

            Console.WriteLine(var1 + var2);//sumamos los valores cuando identifica los numeros
            Console.WriteLine(var1 - var2);
            Console.WriteLine(var1 * var2);
            Console.WriteLine(var1 + var2);
            Console.WriteLine(var1 / var2);
            Console.WriteLine("El resultado es " + (var4 % var3));//el mod, entre parentesis para que divida primero y luego pegue
//-----------------------------------------------------------------------------------------------------------------------------------
            int contador = 4;
            Console.WriteLine("El valor del contador es " + contador);
            contador++;
            Console.WriteLine("Y si le sumamos 1? con ++ es " + contador);//no sirve ++ si se pone directo al imprimir
            contador--;
            Console.WriteLine("Y si le restamos 1? con -- es " + contador);
            contador += 2;
            Console.WriteLine("Y si le sumamos 2? con += es " + contador);
            contador -= 2;
            Console.WriteLine("Y si le restamos 2? con -= es " + contador);
            contador *= 2;
            Console.WriteLine("Y si lo multiplicamos por 2? con *= es " + contador);
            contador /= 2;
            Console.WriteLine("Y si lo dividimos por 2? con /= es " + contador);
//-----------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine(" ");
            Console.WriteLine("------ Operadores de Comparacion -------");
            Console.WriteLine("Es cierto que 3 es igual a 3?: " + (3 == 3));
            Console.WriteLine("Es cierto que 3 es diferente de 4?: " + (3 != 4));
            Console.WriteLine("Es cierto que 3 es diferente de 3?: " + (3 != 3));
            //mismos operadores <, >, <=, >=
            Console.WriteLine(" ");
            Console.WriteLine("------> Operadores de Comparacion (AND OR) && ||");
            Console.WriteLine("3 es igual a 3 y 8 es diferente de cuatro? Eso es verdad?" + (3==3 && 8!=4));
            Console.WriteLine("-8, 80 alguno de esos dos es negativo?" + (-8<0 || 80<0));
            Console.WriteLine("-15, -80 alguno de esos dos es positivo?" + (-15 > 0 || -80 > 0));
            Console.WriteLine("------> Combinando ambos en uno solos");
            Console.WriteLine("8 es menor que 10 y 4 es mayor que 1 O 5 es mayor que 1 " +
                 (8<10 && 4>1 || 5<1));//primero evalua el && y luego el ||

            Console.WriteLine(" ");
            Console.WriteLine("------> Operadores if/else ingreso convertido en una sola linea!!!!");
            Console.WriteLine("Escribe un numero a comprar con 8");
            int num= Convert.ToInt32(Console.ReadLine());//OJOOO!!! lo convertimso en la misma linea!

            if (8 < num)
            {
                Console.WriteLine("Si, 8 es menor que "+num);
            }
            else if (8 > num){
                Console.WriteLine("Si, 8 es mayor que "+ num);
            }
            else
            {
                Console.WriteLine("nada, nada... Circulen que son iguales");
            }

            Console.ReadKey();


        }
    }
}
