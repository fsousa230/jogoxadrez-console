﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Tabuleiro;

namespace jogoxadrez_console
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int l = 0; l < tab.Linhas; l++)
            {
                for (int c = 0; c < tab.Colunas; c++)
                {
                    if (tab.peca(l, c) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.peca(l, c) + " ");
                    }
                }
                Console.WriteLine();
            }
            
        }
    }
}
