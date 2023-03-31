using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Elephant_Swap
{
    internal class Elefante
    {
        public String nome;
        public int EarSize;

        public void WhoAmI()
        {
            System.Windows.Forms.MessageBox.Show("My ears are " + this.EarSize + " inches tall." , this.nome + " says...");
        }
    }
}
