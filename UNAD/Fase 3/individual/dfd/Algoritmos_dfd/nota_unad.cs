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
    public partial class nota_unad : Form
    {
        public nota_unad()
        {
            InitializeComponent();
        }

        private void numeric1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double puntaje = Convert.ToDouble(numeric1.Value);//error al cambiar tipos de dato
            double nota_actual = (puntaje * 5.0) / 375;
            label5.Text = Convert.ToString(Math.Round(nota_actual,2));
            double minima;
            double pts;
            double ajuste;
            double nota75 = puntaje / 100;

            if (nota75 >= 1.75)
            {
                if (nota75 >= 3.0)
                {
                    MessageBox.Show("Felicidades con tu nota actual de "+ nota75 + " logras aprobar el curso");
                }
                else
                {
                    minima = 3.0 - nota75;
                    pts = minima * 100;
                    ajuste = (pts * 5.0) / 125;
                    MessageBox.Show("Tu nota minima requerida para aprobar en el 25% es de: " + ajuste +
                        " exactamente "+ pts +" pts");
                }
            }
            else
            {
                MessageBox.Show("Tu nota final, suponiendo que ganaras el examen con 5.0 estaria en "+
                    (nota75+1.25) + "\n"+
                    "Vaya, esto es incomodo... Ni logrando la maxima nota en el examen podras aprobar :(");
            }
        }
    }
}
