using System;
using tabuleiro.Tabuleiro;
using xadrez;

namespace jogoxadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('a', 1);

            Console.WriteLine(pos.ToPosicao());

            Console.WriteLine(pos);
        }
    }
}
