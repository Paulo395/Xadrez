﻿using System;
using Exceptions;
using tabuleiro;
using xadrez;

namespace Xadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 9));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}