using System;
using tabuleiro;
using Xadrez;

namespace Xadrez // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8,8);
            Tela.imprimirTabuleiro(tab);
        }
    }
}