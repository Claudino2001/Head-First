using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Um_dia_de_Corrida
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelApostaMinima.Text = "Aposta minima de " + numericUpDown1.Minimum + " reais.";
            Cachorro[] cachorros = new Cachorro[3];
            Pessoa[] pessoas = new Pessoa[2];
        }

        private void radioButtonArthur_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonArthur.Checked)
            {
                label1.Text = "Athur";
            }
        }

        private void radioButtonLuca_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLuca.Checked)
            {
                label1.Text = "Luca";
            }
        }

        private void radioButtonClaudino_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonClaudino.Checked)
            {
                label1.Text = "Claudino";
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}
