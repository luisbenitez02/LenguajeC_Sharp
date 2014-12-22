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
namespace Algoritmos_dfd
{
    public partial class num_creciente : Form
    {

        public num_creciente()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ulong a = Convert.ToUInt64(numericUpDown1.Value);
            ulong b = Convert.ToUInt64(numericUpDown2.Value);
            ulong c = Convert.ToUInt64(numericUpDown3.Value);

            if (a < b & b < c & a < c)
            {
                MessageBox.Show("Los numeros SI fueron ingresados en orden creciente: " + a +"< "+ b + "<"+c);
            }else{
                MessageBox.Show("Upps! los numeros NO estan en orden creciente: ");
            }
        }

        private void num_creciente_Load(object sender, EventArgs e)
        {

        }
    }
}
