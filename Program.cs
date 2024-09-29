using DesafioFundamentos.Models;

decimal precoIncial;
decimal precoHora;

Console.WriteLine("Informe o preço inicial:");
precoIncial = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Informe o preço por hora:");
precoHora = Convert.ToDecimal(Console.ReadLine());


Estacionamento es = new(precoIncial, precoHora);

bool menu = true;

while (menu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":

            es.CadastrarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            menu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    Console.WriteLine("Pressione ENTER para continuar");
    Console.ReadLine();
}

Console.WriteLine("Programa encerrado");
