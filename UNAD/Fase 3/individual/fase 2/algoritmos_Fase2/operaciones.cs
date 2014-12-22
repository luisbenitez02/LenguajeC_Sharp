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
    public partial class operaciones : Form
    {
        public operaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ulong a = Convert.ToUInt64(numericUpDown1.Value);
            ulong b = Convert.ToUInt64(numericUpDown1.Value);

            operador i = new operador();
            i.label1.Text = Convert.ToString(a);
            i.label2.Text = Convert.ToString(b);
            i.Show();
        }

        private void operaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
