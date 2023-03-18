using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace __FestaDeJantar
{
    public partial class Form1 : Form
    {
        FestaDeJantar festaDeJantar;

        public Form1()
        {
            InitializeComponent();
            festaDeJantar = new FestaDeJantar((int)numericUpDown1.Value, saudavelBox.Checked, fantasiaBox.Checked);
            MostrarCustoDaFesta();
        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {
            festaDeJantar.CalcularCustoDeDecoracao(fantasiaBox.Checked);
            MostrarCustoDaFesta();
        }

        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {
            festaDeJantar.InformarOpcaoSaudavel(saudavelBox.Checked);
            MostrarCustoDaFesta();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            festaDeJantar.NumeroDePessoas = (int)numericUpDown1.Value;
            MostrarCustoDaFesta();
        }

        private void MostrarCustoDaFesta()
        {
            decimal Custo = festaDeJantar.CalcularCusto(saudavelBox.Checked);
            costLabel.Text = Custo.ToString("c");
        }
    }
}
