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
    public partial class funcion_en_y : Form
    {
        public funcion_en_y()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal x = numericUpDown1.Value;
            decimal resultado = 0;
            if (x < 0)
            {
                resultado = 85 * x;
            }
            else if (x >= 0 & x < 3)
            {
                resultado = (3 * x) + 5;
            }
            else if (x >= 3 & x <= 6)
            {
                resultado = 100 / x;
            }
            else
            {
                resultado = 0;
            }

            MessageBox.Show("Para el valor de x= " + x + "\n" + "El valor de y es: " + resultado);
        }
    }
}
