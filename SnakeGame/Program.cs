using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro t = new Tabuleiro();
            t.Linhas = 20;
            t.Colunas = 30;
            t.mat = new string[t.Linhas, t.Colunas];

            t.LinhaAlimeno = 10;
            t.ColunaAlimento = 15;

            t.Iniciar();

            t.Desenhar(null);

            Console.ReadKey();
        }
    }
}
