using Aulaheranca;

Console.Clear();

Console.WriteLine("Bem-vindo ao Zoo, qual tipo de animal gostaria de cadastrar, réptil ou mamífero?");

var opcaoDeCadastro = Console.ReadLine();

if (opcaoDeCadastro.ToLower() == "mamifero")
    cadastrarMamifero();
else if (opcaoDeCadastro.ToLower() == "reptil")
    cadastrarReptil();

static void cadastrarMamifero() {
    Console.WriteLine("Informe o nome do mamífero");
    var nome = Console.ReadLine();

    Console.WriteLine("Informe a espécie do mamífero");
    var especie = Console.ReadLine();

    Mamifero mamifero = new Mamifero(nome, especie);

    mamifero.Mamar();
}

static void cadastrarReptil()
{
    Console.WriteLine("Informe o nome do réptil");
    var nome = Console.ReadLine();

    Console.WriteLine("Informe a espécie do réptil");
    var especie = Console.ReadLine();

    Console.WriteLine("O réptil é venenoso? (sim/nao)");
    var veneno = Console.ReadLine();

    Reptil reptil = new Reptil(nome, especie);

    if(veneno.ToLower() == "sim")
        reptil.PossuiVeneno = true;
    else
        reptil.PossuiVeneno = false;

    reptil.BotarOvo();

}