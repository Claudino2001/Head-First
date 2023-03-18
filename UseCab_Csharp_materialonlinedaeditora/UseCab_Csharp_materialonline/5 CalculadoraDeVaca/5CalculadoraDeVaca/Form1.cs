using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace __CalculadoraDeVaca
{
    public partial class Form1 : Form
    {
        Fazenda fazenda;

        public Form1() {
            InitializeComponent();
            fazenda = new Fazenda(15, 30);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            fazenda.NumeroDeVacas = (int)numericUpDown1.Value;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            Console.WriteLine("É preciso de {0} sacas de ração para {1} vacas.",
                fazenda.SacasDeRacao, fazenda.NumeroDeVacas);
        }

        private void setBags_Click(object sender, EventArgs e)
        {
            // This button no longer works, because we converted BagsOfFeed
            // to a read-only property.
            //
            // farmer.BagsOfFeed = 5;
        }
    }
}
