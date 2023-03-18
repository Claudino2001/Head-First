using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Fun_if_else_statements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                MessageBox.Show("The box is not checked.");
            }

            if (checkBox1.Checked)
            {
                if(label1.BackColor == Color.Red)
                {
                    label1.BackColor = Color.Blue;
                }
                else 
                {
                    label1.BackColor = Color.Red;
                }
            }
        }
    }
}
