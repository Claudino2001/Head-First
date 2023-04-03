using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Um_dia_de_Corrida
{
    public class Pessoa
    {
        public string nome;
        public Aposta minhaAposta;
        public int dinheiro;
        public RadioButton myRadioButton;
        public Label myLabel;

        public void UpdateLabels()
        {
            
        }

        public void LimparAposta() { }
        
        public bool LocalDeAposta()
        {
            minhaAposta = new Aposta();
            minhaAposta.apostador = this;

            return false;
        }

        public void Cobrar(int ganhador) 
        {
            //cobre minha aposta se eu ganhei
        }



    }
}
