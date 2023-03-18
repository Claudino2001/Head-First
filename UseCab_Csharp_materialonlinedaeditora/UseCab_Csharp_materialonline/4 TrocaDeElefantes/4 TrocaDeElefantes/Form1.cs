using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace __TrocaDeElefantes
{
    public partial class Form1 : Form
    {
        Elefante lucinda;
        Elefante lloyd;
        public Form1()
        {
            InitializeComponent();
            lucinda = new Elefante() { Nome = "Lucinda", tamanhoDaOrelha = 33 };
            lloyd = new Elefante() { Nome = "Lloyd", tamanhoDaOrelha = 40 };
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.QuemSouEu();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.QuemSouEu();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Elefante holder;
            holder = lloyd;
            lloyd = lucinda;
            lucinda = holder;
            MessageBox.Show("Objetos trocados...");
        }

    }

}