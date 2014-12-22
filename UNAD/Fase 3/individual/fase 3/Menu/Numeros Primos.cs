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
    public partial class Numeros_Primos : Form
    {
        public Numeros_Primos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint num = Convert.ToUInt32(numericUpDown1.Value);
            es_primo(num);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void es_primo(uint num)
        {
            if (num == 1)
            {
                textico.Text = "El Numero NO es Primo";
            }
            else
            {
                uint div,cont;
                cont = 0;
                for (uint i = 1; i <= num; i++)
                {
                    div = num % i;
                    if (div == 0)
                    {
                        cont += 1;
                    }
                    if (cont > 2)
                    {
                        break;
                    }
                }
                if (cont == 2)
                {
                    textico.Text = "El Numero SI es Primo";
                }
                else
                {
                    textico.Text = "El Numero NO es Primo";
                }
            }

        }

        private void Numeros_Primos_Load(object sender, EventArgs e)
        {

        }
    }
}
