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
    public partial class triangulos : Form
    {
        public triangulos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tipotriangulo(int a,int b,int c)
        {
            if (a == b & a==c)
            {
                label6.Text = "El Triangulo es Equilatero";
            }else if(a!=b & a!=c & c!=b){
                label6.Text = "El Triangulo es Escaleno";
            }
            else
            {
                label6.Text = "El Triangulo es Isoceles";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
                a = Convert.ToInt32(numericUpDown1.Value);
                b = Convert.ToInt32(numericUpDown2.Value);
                c = Convert.ToInt32(numericUpDown3.Value);

                tipotriangulo(a, b, c);
        }
    }
}
