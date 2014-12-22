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
    public partial class Formulario : Form
    {
        byte cont=1;
        byte pasan=0;
        byte postulados;
        byte edad;
        public Formulario()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            edad= Convert.ToByte(numericUpDown1.Value);
            if (cont <= postulados)
            {
                if (edad >= 18 & radioButton1.Checked & radioButton4.Checked)
                {
                    MessageBox.Show("El Aspirante es aceptado");
                    pasan++;
                }
                else
                {
                    MessageBox.Show("No cumple las condiciones");
                }
                cont++;
                label3.Text= "Postulante " + cont + " de " + postulados;
                if (cont > postulados)
                {
                    MessageBox.Show("Seleccion Terminada \n"+
                        "Lograron pasar "+ pasan + " Aspirantes");

                    Formulario.ActiveForm.Close();
                }
            }
            
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            postulados = Convert.ToByte(label4.Text);
            label3.Text = "Postulante " + cont + " de " + postulados;
        }
    }
}
