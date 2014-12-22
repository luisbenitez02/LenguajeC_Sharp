using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shell32;

namespace videos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gestiona_tiempo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gestiona_tiempo()//tiene que ser prive para escribir en el label
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
            label1.Text = Convert.ToString(tiempoformato);
            //Console.WriteLine("El total de tiempo de los videos es de: " + tiempoformato);
            //Console.ReadLine();
        }
    }
}
