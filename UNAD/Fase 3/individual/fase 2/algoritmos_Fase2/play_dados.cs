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
//Fecha: 27/111/2014
//Doy fe que este ejercicio es de mi autoría,
//en caso de encontrar plagio la nota de todo mi
//trabajo debe ser de CERO además de las respectivas sanciones a que haya lugar
namespace algoritmos_Fase2
{
    public partial class play_dados : Form
    {
        ulong monto1,monto2,monto;
        bool turno;
        string name1, name2;
        public play_dados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random dadito = new Random();
            byte estetiro = Convert.ToByte(dadito.Next(1, 6));
            byte apuesta = Convert.ToByte(numericUpDown1.Value);
            switch (turno)
            {
                case true:
                    if (estetiro == apuesta)
                    {
                        monto1 += 500;
                        MessageBox.Show("¡Acertaste!, ganas +500");
                    }
                    else
                    {
                        MessageBox.Show("Uy.. Mala suerte, pierdes -500");
                        monto1 -= 500;
                        if (monto1 < 500)
                        {
                            MessageBox.Show("Te has quedado sin dinero, el juego termino");
                            balance();
                        }
                    }
                    if (monto1 >= 500)
                    {
                        turno = false;
                        MessageBox.Show("Es el turno de " + name2);
                        label4.Text = name2 + ", apuestale a un número";
                        label6.Text = "Saldo Actual: " + monto2;
                    }
                    
                    break;
                case false:
                    if (estetiro == apuesta)
                    {
                        monto2 += 500;
                        MessageBox.Show("¡Acertaste!, ganas +500");
                    }
                    else
                    {
                        MessageBox.Show("Uy.. Mala suerte, pierdes -500");
                        monto2 -= 500;
                        if (monto2 < 500)
                        {
                            MessageBox.Show("Te has quedado sin dinero, el juego termino");
                            balance();
                        }
                    }
                    if (monto2 >= 500)
                    {
                        turno = true;
                        MessageBox.Show("Es el turno de " + name1);
                        label4.Text = name1 + ", apuestale a un número";
                        label6.Text = "Saldo Actual: " + monto1;
                    }
                    break;
                    
            }
          
        }

        private void play_dados_Load(object sender, EventArgs e)
        {
            monto = Convert.ToUInt64(label3.Text);
            monto1 = monto;
            monto2 = monto;
            turno = true;
            name1 = label1.Text;
            name2 = label2.Text;
            label4.Text = name1 + ", apuestale a un número";
            label6.Text = "Saldo Actual: " + monto1;

        }
        private void balance()
        {
            MessageBox.Show("BALANCE \n" + name1+" finaliza con "+ "$"+monto1+"\n"
                +name2+" finaliza con "+ "$"+monto2);
           play_dados.ActiveForm.Close();
        }

        private void play_dados_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show("BALANCE \n" + name1 + " finaliza con " + "$" + monto1 + "\n"
                + name2 + " finaliza con " + "$" + monto2);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
