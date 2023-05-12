namespace MeuPrimeiroPrograma_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const string textoOlaMundo = "olá mundo, meu primeiro programa C#! Feito por ";

            string nomeCompleto;

            int idade;

            Console.Clear();

            Console.WriteLine("Qual o seu nome inteiro?");

            nomeCompleto = Console.ReadLine()!;

            Console.WriteLine("Qual a sua idade?");

            idade = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(textoOlaMundo + nomeCompleto + " que tem " + idade + " anos.");
        }
    }
}