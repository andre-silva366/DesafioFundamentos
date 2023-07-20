
using DesafioFundamentos.Models;

Console.Clear();
Console.WriteLine("\nSeja bem vindo ao sistema de estacionamento!\n");
Console.Write("Digite o preço inicial: ");
double precoInicial = Convert.ToDouble(Console.ReadLine());
Console.Write("Agora digite o preço por hora: ");
double precoPorHora = Convert.ToDouble(Console.ReadLine());

Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

Console.Clear();
int opcao = 0;
do
{
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo\n2 - Remover veículo\n3 - Listar veículos\n4 - Encerrar");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            estacionamento.CadastrarVeiculo();
            break;
        case 2:
            estacionamento.RemoverVeiculo();
            break;
        case 3:
            estacionamento.ListarVeiculos();
            break;    

    }
} while (opcao != 4);
Console.Clear();
Console.WriteLine("Obrigado por utilizado nosso sistema!!!");
Console.ReadKey();


