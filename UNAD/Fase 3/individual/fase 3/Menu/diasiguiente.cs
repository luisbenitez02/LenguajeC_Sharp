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
    public partial class diasiguiente : Form
    {
        public diasiguiente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dia = dateTimePicker1.Value;
            DateTime manana = dia.AddDays(1);
            MessageBox.Show("El dia siguiente sera exactamente " + manana.ToString("dddd") + " " +
                manana.ToString("dd") + " de " + manana.ToString("MMMM") + " del " + manana.ToString("yyyy"));
        }
       
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
