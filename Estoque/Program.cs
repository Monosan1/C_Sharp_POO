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

            Console.WriteLine();
            Console.WriteLine($"Dados do Produto: {p}");

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado do estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine($"Dados Atualizados: {p}");

            Console.WriteLine();
            Console.Write("Digite o número de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine($"Dados Atualizados: {p}");
            }
        }
    }
