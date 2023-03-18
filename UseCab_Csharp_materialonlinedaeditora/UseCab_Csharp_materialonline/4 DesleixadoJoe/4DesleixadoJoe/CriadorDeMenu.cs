using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace __DesleixadoJoe
{
    public class CriadorDeMenu
    {
        public Random Randomico;

        string[] Carnes = { "Rosbife", "Salame", "Peito de Peru", "Presunto", "Pastrami" };

        string[] Condimentos = { "Mostarda amarela", "Mostarda Marrom",
                   "Mostarda com Mel", "Maionese", "Ketchup", "Molho Francês" };

        string[] Paes = { "Centeio", "Branco", "Trigo", "Integral",
                   "Pão Italiano", "Àrabe" };

        public string GetMenuItem()
        {
            string carneRandomica = Carnes[Randomico.Next(Carnes.Length)];
            string condimentoRandomico = Condimentos[Randomico.Next(Condimentos.Length)];
            string paoRandomico = Paes[Randomico.Next(Paes.Length)];
            return carneRandomica + " Com " + condimentoRandomico + " No " + paoRandomico;
        }
    }
}
