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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            romanos i = new romanos();
            i.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dias_mes i = new dias_mes();
            i.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sumatoria i = new sumatoria();
            i.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            promedio i = new promedio();
            i.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            password i = new password();
            i.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            operaciones i = new operaciones();
            i.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           converter i = new converter();
            i.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            calculadora i = new calculadora();
            i.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dados i = new dados();
            i.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            adivina i = new adivina();
            i.Show();
        }
    }
}
