using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Um_dia_de_Corrida
{
    public class Cachorro
    {
        public int posicaoInicial;
        public int tamanhoDaPista;
        public PictureBox myPictureBox = null;
        public int localizacao = 0; //posicao do dog na pista
        public Random numeroAleatorio;

        public bool Corra()
        {
            //Avance 1,2,3 ou 4 espaços aleatoriamente

            //Atualize a posição de PictureBox no formulário
            Point p = myPictureBox.Location;
            //p.X += distancia;
            //myPictureBox.Location = p;

            //Retorne true se eu ganhei a corrida
            if (localizacao >= tamanhoDaPista) 
                return true;
            else 
                return false;
        }

        public void voltarParaPosicaoInicial()
        {
            this.posicaoInicial = 0;
        }

    }
}
