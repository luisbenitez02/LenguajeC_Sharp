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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conversor i = new conversor();
            i.Show();

        }

        private void conversorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conversor i = new conversor();
            i.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            triangulos i = new triangulos();
            i.Show();
        }

        private void tiposDeTrianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            triangulos i = new triangulos();
            i.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Numeros_Primos i = new Numeros_Primos();
            i.Show();
        }

        private void numeroPrimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Numeros_Primos i = new Numeros_Primos();
            i.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nacimiento i = new nacimiento();
            i.Show();
        }

        private void diasDesdeElNacimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nacimiento i = new nacimiento();
            i.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            diasiguiente i = new diasiguiente();
            i.Show();
        }

        private void queDiaEsMañanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diasiguiente i = new diasiguiente();
            i.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            num_capicua i = new num_capicua();
            i.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            contrasena i = new contrasena();
            i.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            horas_trabajo i = new horas_trabajo();
            i.Show();
        }

        private void númeroCapicúaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            num_capicua i = new num_capicua();
            i.Show();
        }

        private void contraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contrasena i = new contrasena();
            i.Show();
        }

        private void horasDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            horas_trabajo i = new horas_trabajo();
            i.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            adivina_numero i = new adivina_numero();
            i.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            aspirantes i = new aspirantes();
            i.Show();
        }
    }
}
