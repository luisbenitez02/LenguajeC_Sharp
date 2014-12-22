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
    public partial class operador : Form
    {
        ulong a,b,result;
        public operador()
        {
            InitializeComponent();
        }

        private void operador_Load(object sender, EventArgs e)
        {
            a = Convert.ToUInt64(label1.Text);
            b = Convert.ToUInt64(label2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = a + b;
            MessageBox.Show("Resultado: \n"+ a + " + " + b + " = " + result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (a > b)
            {
                result = a - b;
                MessageBox.Show("Resultado: \n" + a + " - " + b + " = " + result);
            }
            else
            {
                MessageBox.Show("Upps! a debe ser mayor que b para operar");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (a != 0 & b != 0)
            {
                result = a * b;
                MessageBox.Show("Resultado: \n" + a + " * " + b + " = " + result);
            }
            else
            {
                MessageBox.Show("Upps! Los numeros deben ser diferentes de 0");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result = a / b;
            MessageBox.Show("Resultado: \n" + a + " / " + b + " = " + result);
        }
        
    }
}
