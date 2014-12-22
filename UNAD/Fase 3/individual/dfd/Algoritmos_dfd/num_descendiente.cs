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
    public partial class num_descendiente : Form
    {
        decimal[] datos = new decimal[3];
        public num_descendiente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datos[0] = numericUpDown1.Value;
            datos[1] = numericUpDown2.Value;
            datos[2] =numericUpDown3.Value;
            decimal almacena;

            for (byte i = 0; i <= 2; i++)
            {
                for (byte cont = 0; cont <= 2; cont++)
                {
                    if (datos[i] < datos[cont])
                    {
                        almacena = datos[i];
                        datos[i] = datos[cont];
                        datos[cont] = almacena;
                    }
                }
            }

            MessageBox.Show("Los numero en orden descendiente son:" + datos[2] + 
                " > " + datos[1] + " > " + datos[0]);
        }

        private void num_descendiente_Load(object sender, EventArgs e)
        {

        }
    }
}
