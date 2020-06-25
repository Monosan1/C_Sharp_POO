using System;
using System.Globalization;

/*namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            ExClass1 x, y;

            x = new ExClass1();
            y = new ExClass1();

            Console.WriteLine("Digite um nome:");
            x.Name = Console.ReadLine();
            Console.WriteLine("Digite a idade:");
            x.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro nome:");
            y.Name = Console.ReadLine();
            Console.WriteLine("Digite a idade:");
            y.Age = int.Parse(Console.ReadLine());

            if (x.Age > y.Age)
            {
                Console.WriteLine($"Pessoa mais velha:{x.Name}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha:{y.Name}");
            }

        }
    }
}*/

namespace Ex1
{
    class Ex2
    {
        static void Main()
        {
            ExClass2 x, y;

            x = new ExClass2();
            y = new ExClass2();

            Console.WriteLine("Digite um nome:");
            x.Name = Console.ReadLine();
            Console.WriteLine("Digite a Salario:");
            x.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) ;
            Console.WriteLine("Digite outro nome:");
            y.Name = Console.ReadLine();
            Console.WriteLine("Digite a Salario:");
            y.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            x.Averege = (x.Salary + y.Salary) / 2;
            Console.WriteLine($"A Média é de: {x.Averege.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
