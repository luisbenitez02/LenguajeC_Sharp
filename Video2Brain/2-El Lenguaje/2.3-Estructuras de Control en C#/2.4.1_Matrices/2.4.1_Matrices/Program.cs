using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4._1_Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
//1.se define el tipo de matriz seguido de corchetes. 2. el nombre seguido del =, 3. new y tipo de dato[longitud]
            string[] miarreglo = new string[5];//un elemento mas para evita el error con el for
            miarreglo[0] = "Daniel";
            miarreglo[1] = "Luis";
            miarreglo[2] = "Carolina";
            miarreglo[3] = "Ana";
            Console.WriteLine("Escribe un nuevo nombre");
            miarreglo[4] = Console.ReadLine();//pedimos el dato

            //con Length capturo el largo exacto de la matriz 
            for (int inu = 0; inu < miarreglo.Length; inu++)
            {
                Console.WriteLine("El elemento #"+ inu +" tiene el nombre: "+ miarreglo[inu]);
            }

            Console.ReadKey();
        }
    }
}
