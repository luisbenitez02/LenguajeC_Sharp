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

namespace _3._1._1_ventanas
{
    public partial class Appventana : Form
    {
        public Appventana()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LinkLabel.Link enlace = new LinkLabel.Link();
            enlace.LinkData= "http://www.unad.edu.co";

            //nombre del componente
            linkLabel1.Links.Add(enlace);
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //ahora hacemos que el usuario pueda ir al link
            //llamamos a using.Diagnostics;

            Process.Start(e.Link.LinkData as string);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
