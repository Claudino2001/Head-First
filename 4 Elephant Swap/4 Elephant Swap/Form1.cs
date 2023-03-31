using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Elephant_Swap
{
    public partial class Form1 : Form
    {

        Elefante Lloyd, Lucinda, copo;

        public Form1()
        {
            InitializeComponent();
            Lloyd = new Elefante() { nome = "Lloyd", EarSize = 28 };
            Lucinda = new Elefante() { nome = "Lucinda", EarSize = 33 };
            copo = new Elefante() { };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Lloyd
            Lloyd.WhoAmI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Lucinda
            Lucinda.WhoAmI();
        }

        private void btn_Swap_Click(object sender, EventArgs e)
        {
            //Swap
            copo = Lucinda;
            Lucinda = Lloyd;
            Lloyd = copo;
        }
    }
}
