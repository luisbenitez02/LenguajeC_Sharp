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
    public partial class aspirantes : Form
    {
        //int[] array = new int[5];

        public aspirantes()
        {
            InitializeComponent();
        }

        private void aspirantes_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ingresos = Convert.ToString(numericUpDown1.Value);
            Formulario ventana = new Formulario();
            ventana.label4.Text = ingresos;

            this.Hide();
            ventana.Show();
        }
    }
}
