using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro.Tabuleiro
{
    class TabuleiroException : Exception
    {
        public TabuleiroException (string message) : base(message)
        {

        }
    }
}
