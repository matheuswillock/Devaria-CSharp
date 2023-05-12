using System.Runtime.CompilerServices;

namespace ProgramaQuartasDeFinais
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();

            Console.WriteLine("Qual o nome do jogador?");

            string NomeDoJogador = Console.ReadLine()!;

            switch (NomeDoJogador)
            {
                case "Daniel":
                case "Matheus":
                case "Lucas":
                case "Otavio":
                case "Mauricio":
                case "Carlos":
                case "André":
                case "Miranda":
                    Console.WriteLine("Jogador autorizado");
                    break;
                default: Console.WriteLine("Jogador não autorizado");
                    break;
            }
        }
    }
}