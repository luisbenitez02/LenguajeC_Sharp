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
    public partial class opcion : Form
    {
        byte puntos = 0;
        byte intentos = 1;
        byte c = 0;
        public opcion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione la palabra correcta para completar la oracion");
        }

        private void opcion_Load(object sender, EventArgs e)
        {
            frases();
        }

        private void frases()
        {
            string[] frase = new string[5];
            frase[0] = "Estudie mucho, __________ no aprobé el curso";//sin embargo
            frase[1] = "Hay que ________ esos resultados nuevamente";//revisar
            frase[2] = "Todos deben ir a votar sin _________";//excepción
            frase[3] = "Tengo mucha ___________ para las matematicas";//perspicacia
            frase[4] = "";//perspicacia
            label2.Text = frase[c];
            switch (c)
            {
                case 0:
                    radioButton1.Text = "menos sin embargo";
                    radioButton2.Text = "sin embargo";//d
                    radioButton3.Text = "más embargo";
                    radioButton4.Text = "Sin embargo";
                    break;
                case 1:
                    radioButton1.Text = "revizar";
                    radioButton2.Text = "rebisar";
                    radioButton3.Text = "revisar";//d
                    radioButton4.Text = "rebizar";
                    break;
                case 2:
                    radioButton1.Text = "excepción";//m
                    radioButton2.Text = "esepción";
                    radioButton3.Text = "exsepción";
                    radioButton4.Text = "exepcíón";
                    break;
                case 3:
                    radioButton1.Text = "perpicasia";
                    radioButton2.Text = "perspicasia";
                    radioButton3.Text = "perpicacia";
                    radioButton4.Text = "perspicacia";//d
                    break;
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            switch (c)
            {
                case 0:
                    if (radioButton2.Checked)
                    {
                        puntos++;
                    }
                    else
                    {
                        MessageBox.Show("Upps! grave error!");
                    }
                    break;
                case 1:
                    if (radioButton3.Checked)
                    {
                        puntos++;
                    }
                    else
                    {
                        MessageBox.Show("Upps! grave error!");
                    }
                    break;
                case 2:
                    if (radioButton1.Checked)
                    {
                        puntos++;
                    }
                    else
                    {
                        MessageBox.Show("Upps! grave error!");
                    }
                    break;
                case 3:
                    if (radioButton4.Checked)
                    {
                        puntos++;
                    }
                    else
                    {
                        MessageBox.Show("Upps! grave error!");
                    }
                    MessageBox.Show("El Juego ha terminado, en total tienes "+ puntos+"/4 puntos");
                    definicion.ActiveForm.Close();
                    break;
                default:
                    break;
            }
            intentos++;
            c++;
            label5.Text = Convert.ToString(puntos);
            label7.Text = Convert.ToString(intentos+" de 4");
            frases();
        }
    }
}
