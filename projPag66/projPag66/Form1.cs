using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projPag66
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "Claudino";
            int x = 3;
            x *= 7;
            double d = Math.PI / 2;
            MessageBox.Show("name is  " + name
                + "\nx is " + x
                + "\nd is " + d);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 10;
            if(x == 10)
            {
                MessageBox.Show("x must be 10");
            }
            else
            {
                MessageBox.Show("x isn't 10");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int someValue = 4;
            string name = "Bobbo Jr.";
            if((someValue == 3) && (name == "Joe"))
            {
                MessageBox.Show("Tudo certo.");
            }
            MessageBox.Show("Errado.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0;
            
            while(count < 10)
            {
                count++;
            }
            for(int i = 0; i < 5; i++)
            {
                count--;
            }
            MessageBox.Show("The answer is " + count );
        }
    }
}
