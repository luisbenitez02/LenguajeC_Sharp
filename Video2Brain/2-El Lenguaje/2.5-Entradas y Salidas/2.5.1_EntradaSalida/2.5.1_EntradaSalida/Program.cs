using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//convocamos la libreria de entradas y salidas
//escribe y lee archivos en el disco.


namespace _2._5._1_EntradaSalida
{
    class Program
    {
        static void Main(string[] args)
        {
//Con esta linea BORRAMOS TODO LO ANTERIOR Y ESCRIBIMOS UNA NUEVA LINEA
            /*
            TextWriter texto = new StreamWriter("prueba.txt");//vamos a escribir
            texto.WriteLine("Mi primera Linea: HOLA!");
            texto.Close();*/
//---------------------------------------------------------------------------------

//CREAMOS NUEVO CONTENIDO SIN BORRAR EL ANTERIOR
            Console.WriteLine("Introduce nombre a registrar");
            string nombre = Console.ReadLine();

            Console.WriteLine("Introduce el telefono a ingresar");
            string telefono = Console.ReadLine();

            StreamWriter texto = File.AppendText("prueba.csv");
            texto.WriteLine(nombre + ","+ telefono);
            texto.Close();
            Console.WriteLine("Tu registro se agrego correctamente al archivo");
            
//VAMOS A LEER TODO LINEA A LINEA
            string line;
            int count = 0;
            StreamReader file = new StreamReader("prueba.csv");

            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                count++;
            }
            Console.WriteLine("No hay mas registros para ver");
            file.Close();
            //Vamos a leer todo el documento .txt y lo imprimimos
            /*
            TextReader leertexto = new StreamReader("prueba.txt");
            Console.WriteLine(leertexto.ReadLine());
            leertexto.Close();*/
            Console.ReadKey();
        }
    }
}
