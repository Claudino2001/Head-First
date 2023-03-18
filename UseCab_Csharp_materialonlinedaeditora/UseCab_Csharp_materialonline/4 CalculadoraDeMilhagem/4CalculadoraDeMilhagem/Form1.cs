using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace __CalculadoraDeMilhagem
{
    public partial class Form1 : Form
    {
        int milhagemInicial;
        int milhagemFinal;
        double milhasViajadas;
        double valorReembolso = .39;
        double quantidadeDevida;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            milhagemInicial = (int)numericUpDown1.Value;
            milhagemFinal = (int)numericUpDown2.Value;
            if (milhagemInicial <= milhagemFinal)
            {
                milhasViajadas = milhagemFinal -= milhagemInicial;
                quantidadeDevida = milhasViajadas *= valorReembolso; 
                label4.Text = "$" + quantidadeDevida;
            }
            else
            {
                MessageBox.Show("A Milha inicial deve ser menor do que a Milha Final",
                                "Não consigo calcular a milhagem");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milhasViajadas + " Milhas", "Milhas Viajadas");
        }

    }
}