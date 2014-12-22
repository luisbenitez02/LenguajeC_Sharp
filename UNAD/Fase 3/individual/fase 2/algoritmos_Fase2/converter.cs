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
    public partial class converter : Form
    {
        public converter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "De decimal a binario:";
            ulong num = Convert.ToUInt64(numericUpDown1.Value);

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
                ulong residuo;
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
                ulong resultado = Convert.ToUInt64(acumula + Math.Pow(10, i));
                textBox1.Text = Convert.ToString(resultado);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "De decimal a Octal:";
            double acumula,i,residuo,result;
            ulong num = Convert.ToUInt64(numericUpDown1.Value);

            acumula = 0;
            i = 0;
            do
            {
                residuo = num % 8;
                acumula = acumula + (Math.Pow(10, i)) * residuo;
                i = i + 1;
                num = num / 8;
            } while (num >= 8);

            result = acumula + Math.Pow(10, i) * num;
            textBox1.Text = Convert.ToString(result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "Binario a Decimal:";
            ulong num = Convert.ToUInt64(numericUpDown1.Value);
            double i,result;
            i = 0;
            result = 0;
            while (num >= 1)
            {
                result = result + (num % 10) * Math.Pow(2, i);
                i++;
                num = num / 10;
            }
            textBox1.Text = Convert.ToString(result);
        }
    }
}
