using System;
using Entities.Tabuleiro;

namespace jogoxadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8,8);
            Tela.imprimirTabuleiro(tab);
        }
    }
}
