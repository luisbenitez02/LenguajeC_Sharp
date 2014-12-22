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
    public partial class dias_mes : Form
    {
        string dias1 = "tiene treinta y un (31) días";
        string dias2 = "tiene treinta (30) días";
        public dias_mes()
        {
            InitializeComponent();
        }

        private void dias_mes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte numero = Convert.ToByte(numericUpDown1.Value);
            dias(numero);
        }
        private void dias(byte numero)
        {
            switch (numero)
            {
                case 1:
                    label3.Text = "Enero, " + dias1;
                    break;
                case 2:
                    label3.Text = "Febrero, tiene 28 días \n 29 en año bisiesto";
                    break;
                case 3:
                    label3.Text = "Marzo, " + dias1;
                    break;
                case 4:
                    label3.Text = "Abril, " + dias2;
                    break;
                case 5:
                    label3.Text = "Mayo, " + dias1;
                    break;
                case 6:
                    label3.Text = "Junio, " + dias2;
                    break;
                case 7:
                    label3.Text = "Julio, " + dias1;
                    break;
                case 8:
                    label3.Text = "Agosto, " + dias1;
                    break;
                case 9:
                    label3.Text = "Septiembre, " + dias2;
                    break;
                case 10:
                    label3.Text = "Octubre, " + dias1;
                    break;
                case 11:
                    label3.Text = "Noviembre, " + dias2;
                    break;
                case 12:
                    label3.Text = "Diciembre, " + dias1;
                    break;
                default:
                    break;
            }
        }
    }
}
