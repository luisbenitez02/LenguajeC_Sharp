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
    public partial class lados : Form
    {
        decimal[] laditos = new decimal[4];
        public lados()
        {
            InitializeComponent();
        }

        private void lados_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            laditos[0] = numeric1.Value;
            laditos[1] = numeric2.Value;
            laditos[2] = numeric3.Value;
            laditos[3] = numeric4.Value;
            motor(laditos);
        }

        private void motor(decimal[] datos)
        {
            byte contador=0;
            for (byte cont = 1; cont <= 4; cont++)
            {
                for (byte i = 1; i <= 4; i++)
                {
                    if (laditos[cont - 1] == laditos[i - 1])
                    {
                        contador++;
                    }
                }
            }
            if (contador == 8)
            {
                MessageBox.Show("Tienes un Rectangulo");
            }
            else if (contador == 16)
            {
                MessageBox.Show("¡Tienes un Cuadrado!");
            }
            else
            {
                MessageBox.Show("Upps! Estas medidas no son correctas");
            }
        }
    }
}
