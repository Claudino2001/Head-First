using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Calculadora_de_Reembolso
{
    public partial class Form1 : Form
    {
        int strantingMilege, endingMilege;
        double milesTraveled, reimburseRate = 0.39, amountOwed;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            strantingMilege = (int)numericUpDown1.Value;
            endingMilege = (int)numericUpDown2.Value;
            if (strantingMilege <= endingMilege)
            {
                milesTraveled = endingMilege - strantingMilege;
                amountOwed = milesTraveled * reimburseRate;
                label4.Text = "$" + amountOwed;
            }
            else
            {
                MessageBox.Show("A quilometragem inicial deve ser menor do que a quilometragem final.", "Impossível calcular");
            }
        }

        private void btnMiles_Click(object sender, EventArgs e)
        {
            //strantingMilege = (int)numericUpDown1.Value;
            //endingMilege = (int)numericUpDown2.Value;
            MessageBox.Show(milesTraveled + " milhas.", "Milhas percorridas");
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
