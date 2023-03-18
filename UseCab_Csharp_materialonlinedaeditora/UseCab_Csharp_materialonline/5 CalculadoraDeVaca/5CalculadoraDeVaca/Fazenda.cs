using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace __CalculadoraDeVaca
{
    class Fazenda
    {
        public int SacasDeRacao { get; private set; }

        public int AlimentadorMultiplo { get; private set; }

        private int numeroDeVacas;
        public int NumeroDeVacas
        {
            get
            {
                return numeroDeVacas;
            }
            set
            {
                numeroDeVacas = value;
                SacasDeRacao = numeroDeVacas * AlimentadorMultiplo;
            }
        }

        public Fazenda(int numeroDeVacas, int alimentadorMultiplo)
        {
            AlimentadorMultiplo = alimentadorMultiplo;
            this.NumeroDeVacas = numeroDeVacas;
        }
    }
}
