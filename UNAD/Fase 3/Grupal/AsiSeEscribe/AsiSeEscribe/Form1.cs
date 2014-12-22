using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AsiSeEscribe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selecciona una de las 3 opciones para empezar a jugar \n" +
                "1.Definición: Veras una definición y debes escribir la palabra a la cual se refiere. \n" +
                "2.Opción Múltiple: Selecciona la manera correcta de escribir una palabra.\n" +
                "3.Escritura: Completa la oración con la palabra correcta. \n" +
                "Codigo original de Sergio Andres Salazar, reeditado y aplicacion de interfa grafica\n"+
                "Por Luis Benitez \n" + "Luis Hernando Benitez \n" +
                "Diana Ximena Castaño \n" + "Sergio Andres Salazar \n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A continuación se presentan una serie de definiciones."+ 
            "Escriba la palabra, en singular, que corresponde.");

            definicion i = new definicion();
            i.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione la palabra correcta para completar la oracion");

            opcion i = new opcion();
            i.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Completa la oración con la palabra correcta.");

            escritura i = new escritura();
            i.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LinkLabel.Link enlace = new LinkLabel.Link();
            enlace.LinkData = "https://twitter.com/tecnobeni";

            //nombre del componente
            linkLabel1.Links.Add(enlace);

            MessageBox.Show("CREDITOS \n" + "Grupo 301303_74, Algoritmos UNAD \n" + "Luis Hernando Benitez \n"+
                "Diana Ximena Castaño \n"+"Sergio Andres Salazar \n"+ "\n pulsa aceptar para continuar");
        }
    }
}
