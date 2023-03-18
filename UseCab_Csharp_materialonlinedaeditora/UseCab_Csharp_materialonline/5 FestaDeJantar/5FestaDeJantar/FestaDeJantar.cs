using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace __FestaDeJantar
{
    public class FestaDeJantar
    {
        const int custoDeComidaPorPessoa = 25;

        private int numeroDePessoas;
        public int NumeroDePessoas {
            get { return numeroDePessoas; }
            set
            {
                numeroDePessoas = value;
                CalcularCustoDeDecoracao(DecoracaoDeFantasia);
            }
        }
        private bool DecoracaoDeFantasia;

        public decimal custoDeBebidaPorPessoa;
        public decimal custoDeDecoracao = 0;

        public FestaDeJantar(int numeroDePessoas, bool opcaoSaudavel, bool decoracaoDeFantasia)
        {
            this.NumeroDePessoas = numeroDePessoas;
            this.DecoracaoDeFantasia = decoracaoDeFantasia;
            InformarOpcaoSaudavel(opcaoSaudavel);
            CalcularCustoDeDecoracao(decoracaoDeFantasia);
        }

        public void InformarOpcaoSaudavel(bool opcaoSaudavel)
        {
            if (opcaoSaudavel)
            {
                custoDeBebidaPorPessoa = 5.00M;
            }
            else
            {
                custoDeBebidaPorPessoa = 20.00M;
            }
        }

        public void CalcularCustoDeDecoracao(bool fantasia)
        {
            DecoracaoDeFantasia = fantasia;
            if (fantasia)
            {
                custoDeDecoracao = (NumeroDePessoas * 15.00M) + 50M;
            }
            else
            {
                custoDeDecoracao = (NumeroDePessoas * 7.50M) + 30M;
            }
        }

        public decimal CalcularCusto(bool opcaoSaudavel)
        {
            decimal custoTotal = custoDeDecoracao + ((custoDeBebidaPorPessoa + custoDeComidaPorPessoa) * NumeroDePessoas);

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
