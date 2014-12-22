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
    public partial class prestamos : Form
    {
        public prestamos()
        {
            InitializeComponent();
        }

        private void prestamos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal inicial=numericUpDown1.Value;
            decimal final = numericUpDown2.Value;
            decimal ajuste;
            decimal intereses;
            decimal porcent_interes;
            decimal interes_mensual;
            if ((final >= inicial) & (inicial>0))
            {
                ajuste = final - inicial;
                intereses = ajuste / 12;
                porcent_interes=(ajuste*100)/inicial;
                interes_mensual = porcent_interes / 12;

                if (intereses > 0)
                {
                    MessageBox.Show("Tus intereses mensuales son de $" + Math.Round(intereses,2) +
                        " pesos \n" + "con una tasa de interes anual del " +
                        porcent_interes + "%"
                        + "\n Ajustado a interes mensual de " + Math.Round(interes_mensual,2) + "%");
                }
                else
                {
                    MessageBox.Show("Eyy! tu tasa de interes mensual es de " + 0 +
                        " pesos!! \n" + " ¡Que Bien!");
                }
            }
            else
            {
                MessageBox.Show("Upps! No puedes devolver menos de lo que pediste prestado, es de mala educacion. Quiza ingresaste algun valor mal");
            }
        }
    }
}
