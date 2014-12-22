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
//Fecha: 24/11/2014
//Doy fe que este ejercicio es de mi autoría,
//en caso de encontrar plagio la nota de todo mi
//trabajo debe ser de CERO además de las respectivas sanciones a que haya lugar
namespace Algoritmos_dfd
{
    public partial class romanos : Form
    {
        string[] roman = new string[10];
            
        public romanos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte num= Convert.ToByte(numericUpDown1.Value);
            label3.Text = "El numero " + num + " expresado en romanos es:";
            label4.Text = roman[num-1];
        }

        private void romanos_Load(object sender, EventArgs e)
        {
            roman[0] = "I";
            roman[1] = "II";
            roman[2] = "III";
            roman[3] = "IV";
            roman[4] = "V";
            roman[5] = "VI";
            roman[6] = "VII";
            roman[7] = "VIII";
            roman[8] = "IX";
            roman[9] = "X";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
