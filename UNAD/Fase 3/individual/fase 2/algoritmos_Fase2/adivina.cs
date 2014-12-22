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
    public partial class adivina : Form
    {
        bool r;
        public adivina()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            r = true;
            adivina_basico i = new adivina_basico();
            i.label2.Text = Convert.ToString(r);
            i.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            r = false;
            adivina_basico i = new adivina_basico();
            i.label2.Text = Convert.ToString(r);
            i.Show();
        }
    }
}
