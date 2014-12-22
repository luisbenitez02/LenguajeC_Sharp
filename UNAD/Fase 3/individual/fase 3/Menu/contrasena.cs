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
    public partial class contrasena : Form
    {    
        public contrasena()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void contrasena_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            // The password character is an asterisk.
            textBox1.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            textBox1.MaxLength = 4;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mypass = textBox1.Text;
            //label3.Text = mypass;

            string cadena = "";
            for (int i = mypass.Length - 1; i >= 0; i--)
            {
                cadena = cadena + mypass.Substring(i, 1);
            }
            label4.Text = "Se entrego al servidor:";
            label3.Text = cadena;
            label5.Text = "ingresaste: " + mypass;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }    
    }
}
