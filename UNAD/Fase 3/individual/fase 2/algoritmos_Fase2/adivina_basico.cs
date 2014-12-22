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
    public partial class adivina_basico : Form
    {
        ushort numerito;
        string rr;
        ushort cont;
        public adivina_basico()
        {
            InitializeComponent();
        }

        private void adivina_basico_Load(object sender, EventArgs e)
        {
            rr = label2.Text;
            Random n = new Random();
            numerito = Convert.ToUInt16(n.Next(1, 1000));

        }

        private void basico(ushort numerito,ushort adivina)
        {
            ushort calc = Convert.ToUInt16(Math.Abs(numerito - adivina));
            cont++;
            if (numerito != adivina)
            {
                if (calc > 750)
                {
                    MessageBox.Show("Esta Helando aqui...");
                }
                else if (calc <= 750 & calc > 400)
                {
                    MessageBox.Show("Friiioo...");
                }
                else if (calc <= 400 & calc > 100)
                {
                    MessageBox.Show("Caliente!");
                }
                else
                {
                    MessageBox.Show("Muy caliente, ¡Que hechas humo!");
                }
            }
            else
            {
                MessageBox.Show("Que bien! ¡¡Acertaste!!!");
                MessageBox.Show("Con"+ cont+" intentos");
                adivina_basico.ActiveForm.Close();
            }
        }
        //------------------------------------------------------------------
        private void experto(ushort numerito, ushort adivina)
        {
            ushort calc = Convert.ToUInt16(Math.Abs(numerito - adivina));
            cont++;
            if (cont<=5){
                if (numerito != adivina)
                {
                    if (calc > 700)
                    {
                        MessageBox.Show("Lejos...");
                    }
                    else 
                    {
                        MessageBox.Show("Cerca... (en un rango de 300)");
                    }                   
                }
                else
                {
                    MessageBox.Show("Que bien! ¡¡Acertaste!!!");
                    MessageBox.Show("Con" + cont + " intentos");
                    adivina_basico.ActiveForm.Close();
                }
            }
            if (cont == 5)
            {
                MessageBox.Show("Upp! se te acabaron los intentos (5)");
                MessageBox.Show("Vuelve luego :)");
                adivina_basico.ActiveForm.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ushort adivina = Convert.ToUInt16(numericUpDown1.Value);
            switch (rr)
            {
                case "True":
                    basico(numerito,adivina);
                    break;
                case "False":
                    experto(numerito,adivina);
                    break;
                default:
                    break;
            }
        }
    }
}
