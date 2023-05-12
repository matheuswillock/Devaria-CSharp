using System;

namespace ProgramaDeEstruturaDeRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Sejam todos bem-vindos ao torneio de Poker Devaria!\n");

            //ExemploForEach();
            //ExemploFor();

            //ExemploWhile();

            ExemploDoWhile();

            Console.WriteLine("Qual o nome do jogador?");

            bool validarJogador = false;

            string nomeDoJogador = Console.ReadLine()!;

            switch (nomeDoJogador)
            {
                case "Daniel":
                case "Matheus":
                case "Lucas":
                case "Otavio":
                case "Mauricio":
                case "Carlos":
                case "André":
                case "Miranda":
                    Console.WriteLine("Jogador autorizado para o torneio de poker");
                    validarJogador = true;
                    break;
                default:
                    Console.WriteLine("Jogador não autorizado para o torneio de poker");
                    break;
            }

            if (validarJogador)
            {
                Console.WriteLine("Quantas vitórias você conquistou?");
                int qtdVitorias = Convert.ToInt32(Console.ReadLine());
                int pontuacaoAtual = PontuacaoDoJogador(qtdVitorias);
                Console.WriteLine("Você possui " + pontuacaoAtual + " pontos no torneio");
                int pontuacaoNova = BonificarParticipante(pontuacaoAtual);
                Console.WriteLine("Parabéns, você ganhou 1 ponto de bônus! Agora sua pontuação é " + pontuacaoNova);
            }

            // Método de pontuacao do jogador
            int PontuacaoDoJogador(int qtdVitorias)
            {
                const int fatorVitoria = 3;

                int pontuacao = qtdVitorias * fatorVitoria;

                return pontuacao;
            }

            // <étodo de bonificação por participação
            int BonificarParticipante(int pontuacaoAtual)
            {
                pontuacaoAtual++;

                return pontuacaoAtual;

            }

            void ExemploArrays()
            {
                int[] notas = { 78, 67, 90, 95, 10, 14, 22,190,45 };
                List<int> notasDaprova = new List<int>() { 6, 7,8, 6,5, 10, 9, 7 };
            }

            void ExemploForEach() 
            {
                string[] jogadores =
                {
                    "Daniel",
                    "Matheus",
                    "Lucas",
                    "Otavio",
                    "Mauricio",
                    "Carlos",
                    "André",
                    "Miranda",
                };

                foreach (string jogador in jogadores) {
                    Console.WriteLine($"Bem-vindo ás quartas de finais {jogador}!\n");
                }
            }

            void ExemploFor() 
            {
                string[] jogadores =
                {
                    "Daniel",
                    "Matheus",
                    "Lucas",
                    "Otavio",
                    "Mauricio",
                    "Carlos",
                    "André",
                    "Miranda",
                };

                for (int contaJogador = 0; contaJogador < 8; contaJogador++)
                {
                    Console.WriteLine($"Bem-vindo ás quartas de finais {jogadores[contaJogador]}!\n");
                }
            }

            void ExemploWhile()
            {
                Console.WriteLine("Qual a sua pontuação atual?");
                int pontuacaoJogador = Convert.ToInt32( Console.ReadLine() );

                if (pontuacaoJogador < 27)
                {

                    while (pontuacaoJogador < 27)
                    {
                        Console.WriteLine("Jogando!");
                        Console.WriteLine("Você Ganhou? (S/N)");

                        string ganhou = Console.ReadLine();

                        if (ganhou == "S")
                        {
                            pontuacaoJogador = pontuacaoJogador + 3;
                        }
                        else
                        {
                            Console.WriteLine("Infelizmente você está fora do torneio");
                            break;
                        }

                    }

                }
                else 
                {
                    Console.WriteLine("Você já está nas quartas de finais");
                }

                
            }

            void ExemploDoWhile()
            {

                string mensagem = "";

                try
                {
                    Console.WriteLine("Qual a sua pontuação atual?");
                    int pontuacaoJogador = Convert.ToInt32(Console.ReadLine());

                    if (pontuacaoJogador < 27)
                    {

                        do
                        {
                            Console.WriteLine("Jogando!");
                            Console.WriteLine("Você Ganhou? (S/N)");

                            string ganhou = Console.ReadLine();

                            if (ganhou == "S")
                            {
                                pontuacaoJogador = pontuacaoJogador + 3;
                            }
                            else
                            {
                                mensagem = "Infelizmente você está fora do torneio";
                                break;
                            }

                        }
                        while (pontuacaoJogador < 27);
                        mensagem = "Você já está nas quartas de finais";
                    }
                    else
                    {
                        mensagem = "Você está nas quartas de finais";
                    }

                }
                catch (Exception ex)
                {
                    mensagem = "Aconteceu o seguinte erro: " + ex.Message;
                }
                finally 
                {
                    Console.WriteLine(mensagem);
                }

                


            }

        }
    }
}