﻿using tabuleiro;

namespace Xadrez
{
    internal class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for(int i = 0; i<tab.Linhas;i++)
            {
                for(int j = 0; j < tab.Colunas; j++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine();
            }
        }
    }
}