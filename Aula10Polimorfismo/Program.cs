using Aula10Polimorfismo;

Console.Clear();

Console.WriteLine("Digite três produtos a serem comprados:");

List<string> produtos = new List<string>();

for (int i = 0; i < 3; i++) 
{
    produtos.Add(Console.ReadLine());
}

Console.WriteLine("Qual a forma de pagamento? (Pix, Boleto, Cartao)");

string formaPagamentoDesejada = Console.ReadLine();

if (formaPagamentoDesejada == FormasPagamentosEnum.Boleto.ToString())
    new Boleto();
else if (formaPagamentoDesejada == FormasPagamentosEnum.Pix.ToString())
    new Pix();
else if (formaPagamentoDesejada == FormasPagamentosEnum.Cartao.ToString())
    new Cartao();
else
    Console.WriteLine("Forma de pagamento inválida!");
