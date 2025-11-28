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
        private int linhaAlimeno;
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
            get { return linhaAlimeno; }
            set { linhaAlimeno = value; }
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
        public void Desenhar(Cobra cobra)
        {
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
                mat[linhaAlimeno, colunaAlimento] = "🍎";
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
