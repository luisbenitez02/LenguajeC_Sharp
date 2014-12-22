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
//Fecha: 24/111/2014
//Doy fe que este ejercicio es de mi autoría,
//en caso de encontrar plagio la nota de todo mi
//trabajo debe ser de CERO además de las respectivas sanciones a que haya lugar
namespace algoritmos_Fase2
{
    public partial class calculadora : Form
    {
        byte control;
        decimal operat,result;
        public calculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            control = 1;
            operat = numericUpDown1.Value;
            result = result + operat;
            numericUpDown1.Value = result;
        }

        private void calculadora_Load(object sender, EventArgs e)
        {
            operat = 0;
            result = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            control = 2;
            operat = numericUpDown1.Value;
            result = result - operat;
            numericUpDown1.Value = result;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            control = 3;
            operat = numericUpDown1.Value;
            result = result / operat;
            numericUpDown1.Value = result;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            control = 4;
            operat = numericUpDown1.Value;
            result = result * operat;
            numericUpDown1.Value = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operat = 0;
            result = 0;
            numericUpDown1.Value = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            operat = numericUpDown1.Value;
            switch (control)
            {
                case 1:

                    result = result + operat;
                    break;
                case 2:
                    result = result - operat;
                    break;
                case 3:
                    result = result * operat;
                    break;
                case 4:
                    result = result / operat;
                    break;
                default:
                    break;
            }
            MessageBox.Show("Resultado: \n" + result);
            operat = 0;
            result = 0;
            numericUpDown1.Value = 0;
        }
    }
}
