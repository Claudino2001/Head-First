using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace __JoeEBob
{
    public partial class Form1 : Form
    {
        Cara joe;
        Cara bob;
        int banco = 100;

        public Form1()
        {
            InitializeComponent();

            bob = new Cara() { Dinheiro = 100, Nome = "Bob" };
            joe = new Cara() { Dinheiro = 50, Nome = "Joe" };

            UpdateForm();
        }

        public void UpdateForm() {
            dinheiroJoe.Text = joe.Nome + " Tem $" + joe.Dinheiro;
            dinheiroBob.Text = bob.Nome + " Tem $" + bob.Dinheiro;
            dinheiroBanco.Text = "O Banco Tem $" + banco;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (banco >= 10)
            {
                banco -= joe.EmprestarDinheiro(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("O Banco está sem dinheiro");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            banco += bob.EmprestarDinheiro(5);
            UpdateForm();
        }

        private void joeGivesToBob_Click(object sender, EventArgs e)
        {
            bob.ReceberDinheiro(joe.EmprestarDinheiro(10));
            UpdateForm();
        }

        private void bobGivesToJoe_Click(object sender, EventArgs e)
        {
            joe.ReceberDinheiro(bob.EmprestarDinheiro(5));
            UpdateForm();
        }
    }
}
