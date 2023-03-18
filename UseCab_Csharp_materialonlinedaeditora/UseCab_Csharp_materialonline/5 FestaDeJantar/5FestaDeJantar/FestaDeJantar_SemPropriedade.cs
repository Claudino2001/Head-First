using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace __FestaDeJantar
{
    // This is the DinnerParty class from the beginning of the chapter
    public class FestaDeJantar_SemPropriedade
    {
        const int CustoDeComidaPorPessoa = 25;
        public int NumeroDePessoas;
        public decimal CustoDeBebidaPorPessoa;
        public decimal CustoDeDecoracao = 0;

        public void InformarOpcaoSaudavel(bool opcaoSaudavel)
        {
            if (opcaoSaudavel)
            {
                CustoDeBebidaPorPessoa = 5.00M;
            }
            else
            {
                CustoDeBebidaPorPessoa = 20.00M;
            }
        }

        public void CalcularCustoDeDecoracao(bool fantasia)
        {
            if (fantasia)
            {
                CustoDeDecoracao = (NumeroDePessoas * 15.00M) + 50M;
            }
            else
            {
                CustoDeDecoracao = (NumeroDePessoas * 7.50M) + 30M;
            }
        }
        public decimal CalcularCusto(bool opcaoSaudavel)
        {
            decimal custoTotal = CustoDeDecoracao +
                   ((CustoDeBebidaPorPessoa + CustoDeComidaPorPessoa)
                       * NumeroDePessoas);

            if (opcaoSaudavel)
            {
                return custoTotal * .95M;
            }
            else
            {
                return custoTotal;
            }
        }
    }
}
