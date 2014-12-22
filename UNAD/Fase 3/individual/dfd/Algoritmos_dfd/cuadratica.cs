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
    public partial class cuadratica : Form
    {
        double a, b, c,inter,raiz1, raiz2;
        public cuadratica()
        {
            InitializeComponent();
        }

        private void cuadratica_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(numericUpDown1.Value);
            b = Convert.ToDouble(numericUpDown2.Value);
            c = Convert.ToDouble(numericUpDown3.Value);

            if (a != 0)
            {
                inter = Math.Pow(b, 2)-(4*a*c);
                if (inter == 0)
                {
                    raiz1 = b / (2 * a);
                    MessageBox.Show("Es un trinomio cuadrado perfecto, su solucion X= " 
                        + raiz1);
                }
                else if(inter>0){
                    raiz1 = (-b + Math.Sqrt(inter)) / (2 * a);
                    raiz2 = (-b - Math.Sqrt(inter)) / (2 * a);
                    MessageBox.Show("Primera solucion X=" + raiz1 + "\n"+
                        "Segunda Solucion X=" + raiz2);
                }
                else
                {
                    raiz1 = (-b) / (2 * a);
                    raiz2= (Math.Sqrt(Math.Abs(inter)))/(2*a);
                    MessageBox.Show("Contiene dos soluciones complejas: \n" +
                        "X1= "+raiz1 + " + " + raiz2 +"i \n" +
                        "X2= "+raiz1+ " - "+raiz2+"i");
                }
            }
            else
            {
                MessageBox.Show("Upps! El primer termino(a) nunca es 0");
            }
        }
    }
}
