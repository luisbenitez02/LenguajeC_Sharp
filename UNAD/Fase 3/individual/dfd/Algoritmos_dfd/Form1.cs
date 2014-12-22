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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            romanos i = new romanos();
            i.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            prestamos i = new prestamos();
            i.Show();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            dias_semana i = new dias_semana();
            i.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            funcion_en_y i = new funcion_en_y();
            i.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            descuentos i = new descuentos();
            i.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lados i = new lados();
            i.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            nota_unad i = new nota_unad();
            i.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num_creciente i = new num_creciente();
            i.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            num_descendiente i = new num_descendiente();
            i.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cuadratica i = new cuadratica();
            i.Show();
        }
    }
}
