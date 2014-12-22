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
    public partial class escritura : Form
    {
        byte puntos = 0;
        byte intentos = 1;
        byte c = 0;
        public escritura()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Completa la oración con la palabra correcta, utiliza mayusculas, minusculas \n" +
                "y acentos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("No dejes campos vacios");
            }
            else
            {
                string respuesta = textBox1.Text;
                validar(respuesta); 
            }  
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void texto()
        {
            string[] frase = new string[5];
            frase[0] = "¡__ tengo un dolor terrible!";//Ay!
            frase[1] = "el ____ del agua se rompio, llama al plomero";//tubo
            frase[2] = "La ____ de osos esta prohibida";//caza
            frase[3] = "Soy ______,puedo ver el futuro";//vidente
            frase[4] = "";

            label2.Text = frase[c];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void validar(string respuesta)
        {
            string[] word = new string[5];
            word[0] = "Ay!";
            word[1] = "tubo";
            word[2] = "caza";
            word[3] = "vidente";
            byte bul = 0;//control
            if (intentos < 4 & bul==0)
            {
                bul = 1;
                if (word[c] == respuesta)
                {
                    puntos++;
                }
                else
                {
                    MessageBox.Show("Upps! :( no es la palabra correcta o no esta bien escrita");
                }
            }
            else
            {
                if (word[c] == respuesta)
                {
                    puntos++;
                }
                else
                {
                    MessageBox.Show("Upps! :( no es la palabra correcta o no esta bien escrita");
                }

                MessageBox.Show("El Juego Ha terminado, tu puntaje total es de " + puntos + "/4 puntos");
               escritura.ActiveForm.Close();
            }
            intentos++;
            c++;
            label5.Text = Convert.ToString(puntos);
            label7.Text = Convert.ToString(intentos + " de 4");
            texto();
        }

        private void escritura_Load(object sender, EventArgs e)
        {
            texto();
        }
    }
}
