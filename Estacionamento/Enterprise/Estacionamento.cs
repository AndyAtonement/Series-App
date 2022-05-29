using System;
using System.Collections.Generic;
using System.Globalization;

namespace Enterprise
{
    public class Estacionamento
    {
        public decimal PrecoInicial { get; set; }
        public decimal PrecoPorHora { get; set; }

        List<string> veiculos = new List<string>();

        public void AdicionarVeiculo(string veiculo)
        {
            Console.WriteLine("Qual a placa do carro?");
            veiculo = Console.ReadLine().ToUpper().Trim();

            if (string.IsNullOrEmpty(veiculo.ToUpper()))
            {
                Console.WriteLine("Entrada inválida.");
            }
            else if (veiculos.Contains(veiculo.ToUpper()))
            {
                Console.WriteLine("Veículo já está no pátio.");
                Console.WriteLine();
            }
            else
            {
                veiculos.Add(veiculo.ToUpper());
            }
        }

        public void RemoverVeiculo(string veiculo)
        {
            Console.WriteLine("Qual a placa do carro?");
            veiculo = Console.ReadLine();

            if (veiculos.Contains(veiculo.ToUpper()))
            {
                Console.WriteLine("Quantas horas o veículo permaneceu no pátio?");
                int horas = int.Parse(Console.ReadLine());
                decimal total = (horas * PrecoPorHora) + PrecoInicial;
                Console.WriteLine($"Total a pagar: R${total.ToString("F2", CultureInfo.InvariantCulture)}");
                veiculos.Remove(veiculo.ToUpper());
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
        }

        public void ListarVeiculos()
        {
            foreach (var veiculo in veiculos)
            {
                Console.WriteLine($"Veículo no pátio: {veiculo}");
            }
        }
    }
}
