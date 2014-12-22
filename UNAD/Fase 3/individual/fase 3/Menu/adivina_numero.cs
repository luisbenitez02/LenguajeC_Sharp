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
    public partial class adivina_numero : Form
    {
        public adivina_numero()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void adivina_numero_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string player1 = textBox1.Text;
            string player2 = textBox2.Text;
            string intentos = Convert.ToString(numericUpDown1.Value);
            if (String.IsNullOrEmpty(player1) || String.IsNullOrEmpty(player2))
            {
                MessageBox.Show("Ingresa los nombres");
            }
            else
            {
                juego ventana = new juego();
                ventana.label1.Text = player1;
                ventana.label2.Text = player2;
                ventana.label3.Text = intentos;
                this.Hide();
                ventana.Show();
            }
        }
    }
}
