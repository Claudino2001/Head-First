using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// ***
using System.Windows.Forms;

namespace __JoeEBob
{

    public class Cara
    {
        public string Nome;
        public int Dinheiro;

        public int EmprestarDinheiro(int quantidade)
        {
            if (quantidade <= Dinheiro && quantidade > 0)
            {
                Dinheiro -= quantidade;
                return quantidade;
            }
            else
            {
                MessageBox.Show(
                 "Eu não tenho dinheiro suficiente para te emprestar " + quantidade,
                 Nome + " disse...");
                return 0;
            }
        }



        public int ReceberDinheiro(int quantidade)
        {
            if (quantidade > 0)
            {
                Dinheiro += quantidade;
                return quantidade;
            }
            else
            {
                MessageBox.Show(quantidade + " Esta não é uma quantidade que eu tenho ",
                      Nome + " disse...");
                return 0;
            }
        }

    }

}
