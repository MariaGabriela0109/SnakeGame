using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Tabuleiro
    {
        private int linhas;
        private int colunas;
        public string[,] mat;
        private int linhaAlimento;
        private int colunaAlimento;

        public int Linhas
        {
            get { return linhas; }
            set { linhas = value; }
        }
        public int Colunas
        {
            get { return colunas; }
            set { colunas = value; }
        }
        public int LinhaAlimeno
        {
            get { return linhaAlimento; }
            set { linhaAlimento = value; }
        }
        public int ColunaAlimento
        {
            get { return colunaAlimento; }
            set { colunaAlimento = value; }
        }

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            mat = new string[linhas, colunas];
            linhaAlimento = -1;
            colunaAlimento = -1;
            Iniciar();
        }

        public void Iniciar()
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = " ";
                }
            }
        }

        public void GerarAlimento(int[,] corpoCobra, int tamanhoCobra)
        {
            bool posicaoValida = false;
            Random r = new Random();
            int aux1 = 0, aux2 = 0;

            while (!posicaoValida)
            {
                aux1 = r.Next(0, linhas);
                aux2 = r.Next(0, colunas);

                posicaoValida = true;

                for(int i = 0; i < tamanhoCobra; i++)
                {
                    if (corpoCobra[0,i] == aux1 && corpoCobra[1,i] == aux2)
                    {
                        posicaoValida = false;
                        break;
                    }
                }
            }
            linhaAlimento = aux1;
            colunaAlimento = aux2;
        }

        private bool EhCobra(Cobra cobra, int linha, int coluna)
        {
            for (int i = 0; i < cobra.Tamanho; i++)
            {
                if (cobra.Corpo[0, i] == linha && cobra.Corpo[1, i] == coluna)
                {
                    return true;
                }
            }
            return false;
        }

        public void Desenhar(Cobra cobra)
        {
            Console.Clear();

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (i == 0 || i == linhas - 1 || j == 0 || j == colunas - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("■");
                        Console.ResetColor();
                    }
                    else if (i == linhaAlimento && j == colunaAlimento)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("●");
                        Console.ResetColor();
                    }
                    else if (EhCobra(cobra, i, j))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("■");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }



    }
}
