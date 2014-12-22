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
    public partial class sumatoria : Form
    {
        public sumatoria()
        {
            InitializeComponent();
        }

        private void sumatoria_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(numericUpDown1.Value);
            double result = 0;
            for (int i = 0; i <= numero; i++)
            {
                result = result + i;
            }
            label3.Text = "La sumatoria de " + numero + " es:";
            label4.Text = Convert.ToString(result);
        }
    }
}
