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
    public partial class romanos : Form
    {
        public romanos()
        {
            InitializeComponent();
        }

        private void romanos_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ushort num = Convert.ToUInt16(numericUpDown1.Value);
            label3.Text = "";
            label4.Text = "";
            motor(num);
        }

        private void motor(ushort num)
        {
            switch (((num - num % 1000) / 1000) % 10)
            {
                case 1:
                    label4.Text = "";
                    label3.Text = label3.Text + "M";
                    break;
                case 2:
                    label4.Text = "";
                    label3.Text = label3.Text + "MM";
                    break;
                case 3:
                    label4.Text = "";
                    label3.Text = label3.Text + "MMM";
                    break;
                case 4:
                    label4.Text = "_";
                    label3.Text = label3.Text + "IV";
                    break;
                case 5:
                    label4.Text = "_";
                    label3.Text = label3.Text + "V";
                    break;
                case 6:
                    label4.Text = "_";
                    label3.Text = label3.Text + "VI";
                    break;
                case 7:
                    label4.Text = "_";
                    label3.Text = label3.Text + "VII";
                    break;
                case 8:
                    label4.Text = "_";
                    label3.Text = label3.Text + "VIII";
                    break;
                case 9:
                    label4.Text = "_";
                    label3.Text = label3.Text + "IX";
                    break;
                default:
                    break;
            }

            switch (((num - num % 100) / 100) % 10)
            {
                case 1:
                    label3.Text = label3.Text + "C";
                    break;
                case 2:
                    label3.Text = label3.Text + "CC";
                    break;
                case 3:
                    label3.Text = label3.Text + "CCC";
                    break;
                case 4:
                    label3.Text = label3.Text + "CD";
                    break;
                case 5:
                    label3.Text = label3.Text + "D";
                    break;
                case 6:
                    label3.Text = label3.Text + "DC";
                    break;
                case 7:
                    label3.Text = label3.Text + "DCC";
                    break;
                case 8:
                    label3.Text = label3.Text + "DCCC";
                    break;
                case 9:
                    label3.Text = label3.Text + "CM";
                    break;
                default:
                    break;
            }

            switch (((num - num % 10) / 10) % 10)
            {
                case 1:
                    label3.Text = label3.Text + "X";
                    break;
                case 2:
                    label3.Text = label3.Text + "XX";
                    break;
                case 3:
                    label3.Text = label3.Text + "XXX";
                    break;
                case 4:
                    label3.Text = label3.Text + "XL";
                    break;
                case 5:
                    label3.Text = label3.Text + "L";
                    break;
                case 6:
                    label3.Text = label3.Text + "LX";
                    break;
                case 7:
                    label3.Text = label3.Text + "LXX";
                    break;
                case 8:
                    label3.Text = label3.Text + "LXXX";
                    break;
                case 9:
                    label3.Text = label3.Text + "XC";
                    break;
                default:
                    break;
            }
            switch (num % 10)
            {
                case 1:
                    label3.Text = label3.Text + "I";
                    break;
                case 2:
                    label3.Text = label3.Text + "II";
                    break;
                case 3:
                    label3.Text = label3.Text + "III";
                    break;
                case 4:
                    label3.Text = label3.Text + "IV";
                    break;
                case 5:
                    label3.Text = label3.Text + "V";
                    break;
                case 6:
                    label3.Text = label3.Text + "VI";
                    break;
                case 7:
                    label3.Text = label3.Text + "VII";
                    break;
                case 8:
                    label3.Text = label3.Text + "VIII";
                    break;
                case 9:
                    label3.Text = label3.Text + "IX";
                    break;
                default:
                    break;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
