using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Estacionamento()
    {
        private decimal precoIncial, precoHora;
        private List<string?> veiculos = [];

        public Estacionamento(decimal precoIncial, decimal precoHora) : this()
        {
            this.precoIncial = precoIncial;
            this.precoHora = precoHora;
        }
        public void CadastrarVeiculo()
        {
            Console.WriteLine("Informe a placa do veículo");
            string? veiculo = Console.ReadLine();

            // Valida se uma placa foi informada
            if (veiculo != "")
            {
                veiculos.Add(veiculo);
                Console.WriteLine("Veículo adicionado");
            }
            else
            {
                Console.WriteLine("O veículo não pode ser vazio");
            }
        }
        public void RemoverVeiculo()
        {
            // Solicita a posição do veículo a ser removido
            Console.WriteLine("Informe a placa do veículo que deseja remover: ");
            foreach (string? i in veiculos)
            {
                Console.WriteLine(i + "\n ---------------");
            }
            // Armazena a placa do veículo de acordo com a posição informada
            string? placa = Console.ReadLine();

            // Console.WriteLine("Informe a quantidade de horas que o veículo ficou estacionado:");
            // int hora = Convert.ToInt32(Console.ReadLine());
            // decimal precoTotal = precoIncial + precoHora * hora;

            // // Remove o veículo de acordo com a posição informada
            // veiculos.Remove(veiculos[x]);

            // Console.WriteLine($"O veículo de placa {placa} foi removido e o preço total a pagar é de R${precoTotal}");

            if (veiculos.Any(x => x?.ToUpper() == placa?.ToUpper()))
            {
                Console.WriteLine("Informe a quantidade de horas que o veículo ficou estacionado:");
                int hora = Convert.ToInt32(Console.ReadLine());
                decimal precoTotal = precoIncial + precoHora * hora;

                veiculos.Remove(placa);
                Console.WriteLine($"O veículo de placa {placa} foi removido e o preço total a pagar é de R${precoTotal}");
            }
            else
            {
                Console.WriteLine("Placa não encontrada");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Count != 0)
            {
                Console.WriteLine("Veículos cadastrados:");
                foreach (string? i in veiculos)
                {
                    Console.WriteLine(i + "\n ---------------");
                }
            }
            else
            {
                Console.WriteLine("Nenhum veículo cadastrado");
            }

        }
    }
}