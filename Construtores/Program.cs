using System;
using System.Globalization;

namespace Construtores
    {
    class Program
        {
        static void Main(string[] args)
            {

            Console.WriteLine("Entre com os dados dos Produtos");
            Console.WriteLine($"Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            /*Console.WriteLine("Qauntidade no Estoque: ");
            int quantidade = int.Parse(Console.ReadLine());*/

            Produto p = new Produto(nome, preco);


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
