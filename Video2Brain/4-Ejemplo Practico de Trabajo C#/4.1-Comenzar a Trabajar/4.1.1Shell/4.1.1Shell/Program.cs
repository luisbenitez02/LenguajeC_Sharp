using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Shell32;

namespace _4._1._1Shell
{
    class Program
    {
        static void Main(string[] args)
        {
            gestiona_tiempo();
        }
        static void gestiona_tiempo()
        {
            double contartiempo = 0;

            //vamos a acceder al shell
            //llamamos a la libreria IO
            //importamos como referencia Shell32 (del sistema) y luego la llamamos en using
            Shell32.Shell shelito = new Shell32.Shell();
            Shell32.Folder carpeta;


            carpeta = shelito.NameSpace(@"D:\Luis\Mis vídeos\prueba");
            //recorremos uno a uno todos los elementos
            foreach (Shell32.FolderItem2 item in carpeta.Items())
            {
                Console.WriteLine(carpeta.GetDetailsOf(item, 27));//obtenemos la duracion del archivo.
                //convertimos a formato tiempo
                TimeSpan tiempo = TimeSpan.Parse(carpeta.GetDetailsOf(item, 27));
                contartiempo += tiempo.TotalSeconds;//toma el tiempo y lo convierte a segundos
            }
            TimeSpan tiempoformato = TimeSpan.FromSeconds(contartiempo);
            Console.WriteLine("El total segundos es de: " + contartiempo);
            Console.WriteLine("El total de tiempo de los videos es de: " + tiempoformato);
            Console.ReadKey();
        }
    }
}
