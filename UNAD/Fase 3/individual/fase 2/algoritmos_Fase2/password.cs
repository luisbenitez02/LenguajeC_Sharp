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
    public partial class password : Form
    {
        byte i = 1;
        public password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i <= 3)
            {
                double one = (Math.Sqrt(4)) * (5 + 8);
                double two = (Math.Sqrt(100)) + ((Math.Pow(2, 3)) - 1);
                double three = (8 + 10 + 15) * 12 - 293;
                double fin = one * two * three;
                i++;
                double pass = Convert.ToDouble(textBox1.Text);
                if (fin == pass)
                {
                    MessageBox.Show("Has Logrado ingresar! Que bien!... Aunque no hay nada :(");
                }
                else if(i==4){
                    MessageBox.Show("SISTEMA BLOQUEADO, Adios");
                    password.ActiveForm.Close();

                }
                else
                {
                    MessageBox.Show("Contraseña Invalida, intenta nuevamente");
                }
            }
            
        }

        private void password_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.PasswordChar = '*';
            textBox1.MaxLength = 5;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
