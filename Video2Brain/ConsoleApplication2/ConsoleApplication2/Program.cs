using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, suma;
            Console.WriteLine("Escriba el primer número: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el segundo número: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el tercer número: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el cuarto número: ");
            d = int.Parse(Console.ReadLine());
            suma = a + b + c;
            if (suma == d)
                Console.WriteLine("La suma de los 3 primeros SI es igual al cuarto número: ");
            else
                Console.WriteLine("La suma de los 3 primeros NO es igual al cuarto número");


            Console.ReadKey();
        }
    }
}
