using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace __TrocaDeElefantes
{

    class Elefante
    {
        public int tamanhoDaOrelha;
        public String Nome;
        public void QuemSouEu()
        {
            MessageBox.Show("Minhas Orelhas medem " + tamanhoDaOrelha + " Centimetros.",
               Nome + " Disse…");
        }
    }
}
