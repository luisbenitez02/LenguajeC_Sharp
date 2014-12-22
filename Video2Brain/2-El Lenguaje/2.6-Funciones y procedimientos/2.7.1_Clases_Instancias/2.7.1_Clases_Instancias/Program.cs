using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._7._1_Clases_Instancias
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro pingui = new Perro();//pingui es una nueva instancia
            pingui.color = "Cafecito";//asignamos valores a variables
            pingui.edad = 2;
            Console.WriteLine("Pingui tiene " + pingui.edad + " años y es de color " + pingui.color);

            //llamamos una funcion
            pingui.ladra();
/*Creamos otro perrito*/
            Perro vaquichu = new Perro();
            vaquichu.color = "Blanco";
            vaquichu.edad = 5;
            vaquichu.raza = "Aleman";
            Console.WriteLine("Vaquichu tiene " + vaquichu.edad + " años y es de color " + vaquichu.color 
                + " ademas es " + vaquichu.raza);
            Console.ReadKey();
        }
    }

    //una clase puede actuar como contenedor de funciones y caracteristicas
    class Perro
    {
        string colorcito = "gris";//no es vivisble desde afuera de la clase

    //definimos las propiedades genericas que un perro pueda tener
        //estas son de caracter estatico, el perro es negro pero eso no hace nada
        //son caracteristicas
        public string color;//su visibilidad es publica
        public int edad;
        public string raza;

        //los metodos realizan una funcion
        //public aque se ve desde afuera
        public void ladra()
        {
            Console.WriteLine("Guaw! perra");
        }

        public void duerme()
        {
            Console.WriteLine("ZzZzzzzz...");
        }
    }
}
