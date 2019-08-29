using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro.Tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; set; }
        public int QtdeMovimentos { get; protected set; }
        public Tabuleiro Tab { get; set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            QtdeMovimentos = 0;
            Tab = tab;
        }

        public void IncrementarQteMovimentos()
        {
            QtdeMovimentos++;
        }
    }
}
