namespace ProgramaCampeonatoDePoker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

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

        }
    }
}