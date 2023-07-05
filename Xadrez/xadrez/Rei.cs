using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace Xadrez.xadrez
{
    internal class Rei : Peca
    {
        public Rei(Posicao posicao, Cor cor, Tabuleiro tab) : base(posicao, cor, tab)
        {
        }
    }
}
