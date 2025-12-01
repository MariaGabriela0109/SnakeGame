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

        public void Iniciar()
        {
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
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

        public void Desenhar(Cobra cobra)
        {
            GerarAlimento(cobra.Corpo, cobra.Tamanho);

            Console.Clear();
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        mat[i, j] = "■";
                    }
                    else if(i == mat.GetLength(0) - 1)
                    {
                        mat[i, j] = "■";
                    }
                    else if (j == 0)
                    {
                        mat[i, j] = "■";
                    }
                    else if (j == mat.GetLength(1) - 1)
                    {
                        mat[i, j] = "■";
                    }
                    else
                    {
                        mat[i, j] = " ";
                    }
                }
            }
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j]);
                }
                Console.WriteLine();
            }


        }


    }
}
