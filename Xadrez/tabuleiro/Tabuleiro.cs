﻿using System;
using Exceptions;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        public Peca[,] Pecas { private get; set; } // Virgula informa que é uma Matriz e não um Array

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas,colunas];
        }

        public Peca RetornarPeca(int linhas, int colunas)
        {
            return Pecas[linhas,colunas];
        }

        public Peca RetornarPeca(Posicao pos)
        {
            return Pecas[pos.Linha, pos.Coluna];
        }

        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return RetornarPeca(pos) != null;
        }

        public void ColocarPeca(Peca p, Posicao pos)
        {
            if(ExistePeca(pos))
            {
                throw new TabuleiroException("Já existem uma peça nessa posição!");
            }
            Pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }

        public bool PosicaoValida(Posicao pos)
        {
            if (pos.Linha<0 || pos.Linha>=Linhas || pos.Coluna<0 || pos.Coluna>=Colunas)
            {
                return false;
            }
            return true;
        }

        public void ValidarPosicao(Posicao pos)
        {
            if(!PosicaoValida(pos))
            {
                throw new TabuleiroException("Posição Invalida!");
            }
        }
    }
}
