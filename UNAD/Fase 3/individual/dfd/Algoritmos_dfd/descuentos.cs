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
    public partial class descuentos : Form
    {
        public descuentos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string articulo = textBox1.Text;
            double precio = Convert.ToDouble(numericUpDown1.Value);
            double descuento;
            double nuevoprecio;
            string porcent = "";
            if (precio >= 120000)
            {
                descuento = precio * 0.12;
                porcent ="12%";
            }
            else
            {
                descuento = precio * 0.6;
                porcent = "6%";
            }
            nuevoprecio = precio - descuento;
            MessageBox.Show("El nuevo precio para el articulo " + articulo + " es de $" + nuevoprecio + "\n" +
                "Aplicando tu descuento del " + porcent + " corresponde a -$"+descuento + " sobre el precio original");
        }
    }
}
