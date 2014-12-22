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
    public partial class conversor : Form
    {
        public conversor()
        {
            InitializeComponent();
        }

        private void conversor_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            convierte();
        }
        private void convierte()
        {
            int num;
            num = Math.Abs(Convert.ToInt32(numericUpDown1.Value));

            if (num == 1 || num == 0)
            {
                switch (num)
                {
                    case 1: textBox1.Text = Convert.ToString(1);
                        break;
                    case 0: textBox1.Text = Convert.ToString(0);
                        break;
                }

            }
            else
            {
                int residuo;
                double i, acumula;
                acumula = 0;
                i = 0;
                do
                {
                    residuo = num % 2;
                    acumula = acumula + ((Math.Pow(10, i)) * residuo);
                    i++;
                    num = (num / 2);
                } while (num > 1);
                int resultado = Convert.ToInt32(acumula + Math.Pow(10, i));
                textBox1.Text = Convert.ToString(resultado);
            }
        }
    }
}
