using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3._5_BucleFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("la Tabla del 9");
            for (int i = 1;i<10 ; i++)
            {
                Console.WriteLine("9 X "+ i + " = " + (9*i));
            }

            Console.WriteLine("la Tabla de los pares");
            for (int i = 0; i <= 10; i+=2)//Puedes usuar todos los operadores
            {
                Console.WriteLine("2 X " + i + " = " + (2 * i));
            }
/*=======================================================================================================================*/
/*------------------------------------- bulce While -----------------------------*/
            Console.WriteLine("-----------------Bucle While-------------------------------");
            Console.WriteLine("");
            Console.WriteLine("2 por i");
            int cont = 1;//Se le debe asignar un valor obligatoriamente
            while(cont<20){
                Console.WriteLine("2 X " + cont + " = " + (2*cont));
                cont ++;//aqui se modifica la variable
            }
/*=======================================================================================================================*/
/*------------------------------------- bulce Do While -----------------------------*/
            Console.WriteLine("-----------------Bucle Do While-------------------------------");
//El bucle do while primero ejecuta y luego pregunta, eso garantiza que la instruccion se ejecute por lo menos una vez
            int adic = 1;
            do
            {
                Console.WriteLine("Es la vez #" + adic + " que pasas");
            }
            while (adic>10);//requiere punto y coma despues de los parentesis 
            Console.ReadKey();
        }
    }
}
