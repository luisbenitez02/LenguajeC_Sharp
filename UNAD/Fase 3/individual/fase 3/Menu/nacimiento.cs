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
    public partial class nacimiento : Form
    {
        public nacimiento()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime datoviejo = dateTimePicker1.Value;
            DateTime actual = DateTime.Today;
            dias_nacimiento(datoviejo, actual);
        }
        private void dias_nacimiento(DateTime datoviejo, DateTime actual)
        {
            TimeSpan diferencia = actual - datoviejo;

            //diferencia en dias
            int diastotales = diferencia.Days;

            MessageBox.Show("En total han trascurrido " + diastotales + " dias desde tu nacimiento");
        }
    }
}
