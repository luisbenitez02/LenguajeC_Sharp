using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsiSeEscribe
{ 
    public partial class definicion : Form
    {
        byte intentos = 1;
        byte puntos = 0;
        public definicion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A continuación se presentan una serie de definiciones." +
           " Escriba la palabra, en singular, que corresponde. \n"+
           "No se distinge entre mayusculas ni minusculas");
        }

        private void definicion_Load(object sender, EventArgs e)
        {        
                palabras();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
               
            {
                MessageBox.Show("No dejes campos vacios");
            }
            else
            {
                byte n = Convert.ToByte(label9.Text);//del array, cual posicion de word vamos a evaluar
                string respuesta = textBox1.Text;
                respuesta.ToLower();
                intentos++;
                valida(n, respuesta);
            }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void palabras()
        {
            Random m = new Random();
            int x = m.Next(0, 9);

            string[] definitions = new string[10];
            definitions[0] = "Es donde se ponen las banderas en colegios, \n" + "universidades o entidades del estado:";//asta
            definitions[1] = "Corriente o cauce de agua pequeño que puede \n" + "secarse en verano:";//arroyo
            definitions[2] = "Hongo con forma de sombrero sostenido por un pie,\n" + "en muchos casos comestible:";//seta
            definitions[3] = "Acto representativo cuando se pone una bandera\n en el Asta:";//izar
            definitions[4] = "Es una  Persona capaz de ver el futuro:";//vidente
            definitions[5] = "Es una dureza que por roce o presión se forma \n en la piel, generalmente en manos y pies:";//callo
            definitions[6] = "Es el evento donde existen probabilidades \n de ganar o perder:";//azar
            definitions[7] = "Vasija pequeña que se usa para tomar líquidos:";//taza
            definitions[8] = "Descubrir lo secreto, dar indicios de algo, mostrar:";//revelar
            definitions[9] = "Búsqueda y persecución de animales \n para atraparlos o matarlos:";//caza
     
            label2.Text = definitions[x];

            label9.Text = Convert.ToString(x);
        }

        public void valida(byte n,string respuesta)
        {
            byte dare = 0;
            string[] word = new string[10];
            word[0] = "asta";
            word[1] = "arroyo";
            word[2] = "seta";
            word[3] = "izar";
            word[4] = "vidente";
            word[5] = "callo";
            word[6] = "azar";
            word[7] = "taza";
            word[8] = "revelar";
            word[9] = "caza";

            if (intentos < 6)
            {
                while (intentos < 6 & dare==0)
                {
                    dare = 1;
                    if (respuesta == word[n])
                    {
                        label8.Text = "¡Que Bien!";
                        puntos++;
                    }
                    else
                    {
                        label8.Text = "";
                        MessageBox.Show("Upps! la palabra correcta es " + word[n]);
                    }
                    label5.Text = Convert.ToString(puntos);
                    label7.Text = Convert.ToString(intentos) + " de 4";
                }

                if (intentos == 5)
                {
                    label7.Text = "4 de 4";
                    MessageBox.Show("El Juego ha terminado \n tu puntaje total es de " + puntos+"/4");
                    //definicion i = new definicion();
                    //i.Close();
                    definicion.ActiveForm.Close();
                }
                else{
                    palabras();
                }
                
            }

        }
    }
}
