using DesafioAula8;

var mensagem = "";

try
{
    Console.WriteLine("Bem vindo ao cadastro de contas bancároas");

    List<ContaBancaria> listaContas = new List<ContaBancaria>();
    
    for (int contagem = 1; contagem <= 3; contagem++)
    {
        Console.WriteLine($"Digite o tipo da conta {contagem}.");

        string TipoConta = Console.ReadLine();

        Console.WriteLine($"Digite a agência da conta {contagem}.");

        int Agencia = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Digite o número da conta {contagem}.");

        int NumeroConta = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Qual é o saldo da conta {contagem}");

        double SaldoConta = Convert.ToDouble(Console.ReadLine());

        ContaBancaria contaBancaria = new ContaBancaria(TipoConta, NumeroConta, Agencia, SaldoConta);
    
        listaContas.Add( contaBancaria );
    }

    Console.WriteLine("Qual número da conta que você gostaria de ver");
    int NumeroContaBusca = Convert.ToInt32(Console.ReadLine());

    if (listaContas.Where(conta => conta.Numero == NumeroContaBusca).Any())
    {
        ContaBancaria contaBancariaBusca = listaContas.Where(conta => conta.Numero == NumeroContaBusca).FirstOrDefault()!;
        Console.Clear();
        mensagem = contaBancariaBusca.ExibirDadosConta();
    }
    else 
    { 
        mensagem = "Conta inexistente";
    }

    
}
catch (Exception ex)
{
    mensagem = $"O erro encontrado foi {ex.Message}";
}
finally 
{
    Console.WriteLine(mensagem);
}



