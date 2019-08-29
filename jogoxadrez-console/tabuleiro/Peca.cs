using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro.Tabuleiro
{
    abstract class Peca
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

        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();
            for (int l = 0; l < Tab.Linhas; l++)
            {
                for(int c = 0; c < Tab.Colunas; c++)
                {
                    if (mat[l, c])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool PodeMoverPara(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}
