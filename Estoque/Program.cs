using System;
using System.Globalization;

namespace Estoque
    {
    class Program
        {
        static void Main(string[] args)
            {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados dos Produtos");
            Console.WriteLine($"Nome: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Qauntidade no Estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do Produto: {p}");
            }
        }
    }
