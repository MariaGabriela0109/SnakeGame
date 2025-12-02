using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Jogador
    {
        public string nome;
        private int pontuacao;

        public Jogador(string Nome)
        {
            this.nome = Nome;
        }

        public int Pontuação
        {
            get { return pontuacao; }
            set { this.pontuacao = value; }
        }

        public void AdicionarPontos()
        {
            pontuacao += 10;
        }

        public void RegistrarPontuacao()
        {
            try
            {
                using (StreamWriter pontuacao = new StreamWriter("pontuacoes.txt", true))
                {
                    pontuacao.WriteLine($"{nome} - Pontos: {pontuacao}");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao salvar pontuação: " + e.Message);
            }
        }

    }
}
