using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        public string PlacaVeiculo { get; set; }
        public double PrecoInicial{ get; set; }
        public double PrecoPorHora{ get; set; }

        public Estacionamento(double precoInicial, double precoPorHora)
        {
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora;
        }

        List<string> veiculos = new List<string>(); 
        public void CadastrarVeiculo()
        {
            Console.Write("Digite a placa do veiculo para estacionar: ");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine("Veículo adicionado com sucesso\nPressione qualquer tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
        }

        public void RemoverVeiculo()
        {
            Console.Write("Digite a placa do veiculo para remover: ");
            string placa = Console.ReadLine();
            Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
            double qtdeHoras = Convert.ToDouble(Console.ReadLine());
            double total = PrecoInicial + (PrecoPorHora * qtdeHoras);
            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {total}\nPressione qualquer tecla para continuar.");
            veiculos.Remove(placa);
            Console.ReadKey();
            Console.Clear();
        }

        public void ListarVeiculos()
        {
            
            if(veiculos.Count > 0)
            {
                Console.WriteLine("Os veículos estacionados são: ");
                foreach(string veiculo in veiculos)
            {
                Console.WriteLine($"{veiculo}");
            }
            }
            else
            {
                Console.WriteLine("Não há veiculos estacionamentos no momento!");
            }
            Console.WriteLine("Pressione qualquer tecla para continuar.");
            Console.ReadKey();
            Console.Clear();
        }

    }
}