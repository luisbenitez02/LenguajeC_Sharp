using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3._4_swicth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dime el dia de la semana");
            string dia = Console.ReadLine();
            
            switch(dia){
                case "lunes": Console.WriteLine("Hoy es el primer dia de la semana");
                    break;
                case "martes": Console.WriteLine("Hoy es el segundo dia de la semana");
                    break;
                case "miercoles": Console.WriteLine("Hoy es el tercer dia de la semana");
                    break;
                case "jueves": Console.WriteLine("Hoy es el cuarto dia de la semana");
                    break;
                case "viernes": Console.WriteLine("Hoy es el quinto dia de la semana");
                    break;
                case "sabado": Console.WriteLine("Hoy es el dia mas genial de la semana");
                    break;
                case "domingo": Console.WriteLine("Hoy es el dia mas agridulce de la semana");
                    break;
                /*default:
                    Console.WriteLine("Hay un error");*/
            }
            Console.ReadKey();
        }
    }
}
