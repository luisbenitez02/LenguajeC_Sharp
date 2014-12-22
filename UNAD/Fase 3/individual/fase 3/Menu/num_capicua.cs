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
    public partial class num_capicua : Form
    {
        public num_capicua()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numero = Convert.ToString(numericUpDown1.Value);
            capicua(numero);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void capicua(string numero)
        {
            string cadena="";
            for (int i = numero.Length-1; i >= 0; i--)
            {
                cadena=cadena+numero.Substring(i,1);
            }
            if (cadena == numero)
            {
                label3.Text = "El numero " + numero + " SI es Capícua";
                label4.Text ="";
            }else{
                label3.Text = "El numero " + numero + "  NO es Capícua";
                label4.Text = numero + " es diferente a " + cadena;
            }
        }
    }
}
