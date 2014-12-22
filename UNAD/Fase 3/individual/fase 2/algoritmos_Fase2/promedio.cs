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
    public partial class promedio : Form
    {
        decimal prom, ingre, cont,retro;
        public promedio()
        {
            InitializeComponent();
        }

        private void promedio_Load(object sender, EventArgs e)
        {
            cont = 0;
            ingre = 0;
            retro = ingre;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            ingre= numericUpDown1.Value;
            if (ingre != 0)
            {
                prom = prom + ingre;
                cont++;

                if (retro < ingre)
                {
                    retro = ingre;
                }
                label5.Text = "Puedes seguir ingresando numeros";
            }
            else if (ingre == 0)
            {
                prom =((prom) / (cont));
                label5.Text = "Esto se acabo!";
                MessageBox.Show("El número mayor de la serie ingresada es: " + retro + "\n"+
                    "El promedio es: " + prom);
                prom = 0;
                ingre=0;
                cont=0;
                retro=0;
            }
        }
    }
}
