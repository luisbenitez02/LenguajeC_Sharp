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
    public partial class dias_semana : Form
    {
        public dias_semana()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] dias = new string[7];
            dias[0] = "Lunes";
            dias[1] = "Martes";
            dias[2] = "Miercoles";
            dias[3] = "Jueves";
            dias[4] = "Viernes";
            dias[5] = "Sabado";
            dias[6] = "Domingo";

            byte num= Convert.ToByte(numericUpDown1.Value);
            label3.Text = dias[num - 1];
        }
    }
}
