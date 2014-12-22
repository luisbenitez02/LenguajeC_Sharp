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
    public partial class dados : Form
    {
        public dados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string player1 = textBox1.Text;
            string player2 = textBox2.Text;
            ulong monto = Convert.ToUInt64(numericUpDown1.Value);

            play_dados i = new play_dados();
            i.label1.Text = player1;
            i.label2.Text = player2;
            i.label3.Text = Convert.ToString(monto);
            i.Show();
        }
    }
}
