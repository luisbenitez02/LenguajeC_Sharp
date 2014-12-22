using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte talla, centimetros, hermanos;
            talla=32;
            centimetros=175;
            hermanos=0;
            /*
             *mira las varables dinamicas 
             */
            dynamic nombre = "Luis Benitez";// No le importa si es numero, cadena o cualquier cosa, cuando necesite msotrarlo le asigna un tipo
            string mensaje = "Hola soy un mensaje muy largo, asi que estoy contenido en una variable";
            bool eslenguaje = true;
            int dinero = 450000;
            byte edad = 19; //dato entero
            Console.WriteLine("Hola Parceros! mi nombre es "+ nombre + " tengo "+ edad +" años y tengo "+ dinero + " para comprar un perrito :)");//se concatenan con +
            //los datos de numeros no se suman solo se pegan
            Console.WriteLine("Mi talla es de "+ talla+ " y mi altura es de " + centimetros + " centimetros tengo "+ hermanos + " hermanos");
            Console.WriteLine("C# es genial: " + eslenguaje);
            Console.WriteLine(mensaje);

            const double pi = 3.14;//const hace que se gaste menos memoria al entender que la variable jamas va a cambiar
            Console.WriteLine("El valor de Pi es" + pi);


            Console.ReadKey();//detiene el programa
            /* los comentarios largos
             * generan un asteristo ellos mismos
             * genial no?http://msdn.microsoft.com/es-es/library/ms228360%28v=vs.90%29.aspx */

           

        }
    }
}
