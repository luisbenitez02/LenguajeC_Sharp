using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6._1_todofunciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //llamamos a la funcion
            mimetodo("Luis");
            mimetodo("Ediberto");
            mimetodo("Elbert");
            mimetodo("Gomez");
            mimetodo("Torba");
            mimetodo();
            mimetodo("Diego Norrea",35);
            Console.ReadKey();

        }
        //metodo estatico, (void) no devuelve nada en particular
        static void mimetodo(string nombre)
        {
            Console.WriteLine("Hola!" + nombre +" como estas?");
        }
        //Le quitamos el parametro pero tenemos el mismo nombre

//Basicamente le decimos que si tiene un parametro haga tal cosa y ni si que haga otra
        static void mimetodo()
        {
            Console.WriteLine("Hola!" +  " como estas?");
        }

        static void mimetodo(string nombre, byte edad)
        {
            Console.WriteLine("Hola!" + nombre + " como estas?, veo que tienes " + edad + " años ");
        }
    }
}
