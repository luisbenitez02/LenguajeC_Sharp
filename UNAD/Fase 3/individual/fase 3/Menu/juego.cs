using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Nombre del Autor:Luis Hernando Benitez
//Fecha:05/11/2014
//Doy  fe  que  este  ejercicio  es  de mi  autoría,  en  caso de  encontrar plagio  la  nota  de  todo mi 
//trabajo debe ser de CERO además de las respectivas sanciones a que haya lugar 
namespace Menu
{
    public partial class juego : Form
    {
        Random r = new Random();
        byte numerito;
        string player1;
        string player2;
        bool control=true;
        byte intentos;
        byte cont=1;
        public juego()
        {
            InitializeComponent();
        }

        private void juego_Load(object sender, EventArgs e)
        {
            numerito = Convert.ToByte(r.Next(1, 100));
            player1 = label1.Text;
            player2 = label2.Text;
            names.Text = player1;
            intentos = Convert.ToByte(label3.Text);
            contador.Text = "Intento 1 de " + intentos;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cont <= intentos)
            {
                if (numericUpDown1.Value == numerito)
                {
                    MessageBox.Show("Felicidades! Has adivinado el numero");
                    juego.ActiveForm.Close();
                }
                else
                {
                    MessageBox.Show("Upps! sigue intentando...");
                    switch(control){
                        case true:
                            control = false;
                            break;
                        case false:
                            control = true;
                            break;
                    }
                }
                if (control == false)
                {
                    names.Text = player2;
                }
                else
                {
                    names.Text = player1;
                    cont++;
                }
                if (cont > intentos)
                {
                    MessageBox.Show("El Juego ha terminado, el numero era: " + numerito);
                    juego.ActiveForm.Close();
                }
                contador.Text = "Intento " + cont + " de " + intentos;
            }
            else
            {
                MessageBox.Show("El Juego ha terminado, el numero era: " + numerito);
                juego.ActiveForm.Close();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
