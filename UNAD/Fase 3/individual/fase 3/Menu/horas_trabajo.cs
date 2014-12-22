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
//Fecha:20/11/2014
//Doy  fe  que  este  ejercicio  es  de mi  autoría,  en  caso de  encontrar plagio  la  nota  de  todo mi 
//trabajo debe ser de CERO además de las respectivas sanciones a que haya lugar 
namespace Menu
{
    public partial class horas_trabajo : Form
    {
        public horas_trabajo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ushort hours = Convert.ToUInt16(numericUpDown1.Value);
            ushort categoria = Convert.ToUInt16(numericUpDown2.Value);
            double total_deven=0;
            double aux=0;
            double descuentosalud=0;
            double salario_final;
            bool control=false;
            switch (categoria)
            {
                case 1:
                    total_deven = 20000 * hours;
                    break;
                case 2:
                    total_deven = 15000 * hours;
                    break;
                case 3:
                    total_deven = 10000 * hours;
                    break;
                case 4:
                    total_deven = 7500 * hours;
                    break;
            }
            descuentosalud = total_deven * 0.072;
            if (total_deven < 1000000)
            {
                control=true;
                aux = total_deven * 0.15;
                total_deven= total_deven+aux;
            }
            salario_final = total_deven - descuentosalud;
            if (control == false)
            {
                MessageBox.Show("El salario total a pagar es: $" + salario_final + "\n" + " Con un descuento en"
            + " salud de: -$" + descuentosalud);
            }
            else
            {
                MessageBox.Show("El salario total a pagar es: $" + salario_final + "\n" + " Con un descuento en"
            + " salud de: -$" + descuentosalud + "\n"+
            " Se aplico auxilio del 15% por +$"+aux);
            }
        }
    }
}
