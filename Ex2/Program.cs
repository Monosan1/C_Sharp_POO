using System;
using System.Globalization;

namespace Ex2
    {
    /*class Program
        {
        static void Main(string[] args)
            {

            Retangulo x, y;

            x = new Retangulo();
            y = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do Retângulo:");
            x.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Area = {x.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Perímetro ={x.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Diagonal = {x.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");


            }
        }*/

    /*   class EX2
           {
           static void Main(string[] args)
               {
               Funcionario func;
               func = new Funcionario();

               Console.Write("Nome: ");
               func.Nome = Console.ReadLine();
               Console.Write("Salário Bruto: ");
               func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               Console.Write("Imposto: ");
               func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

               Console.WriteLine();
               Console.WriteLine($"Funcionário: {func}");

               Console.WriteLine();
               Console.Write("Digite a porcentagem para aumentar o salário: ");

               double PorcentagemAumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

               func.AumentarSalario(PorcentagemAumento);

               Console.WriteLine();
               Console.WriteLine($"Dados atualizados: {func}");
               }
           }*/
    class EX3
        {
        static void Main(string[] args)
            {
            Aluno aluno;
            aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"NOTA FINAL = {aluno.CalcNotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");
            if (aluno.Aprovado())
                {
                Console.WriteLine();
                }
            else
                {
                Console.WriteLine();
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"NOTA RESTANTE = {aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
                }
            }
        }
    }
