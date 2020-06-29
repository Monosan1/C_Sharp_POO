using System;
using System.Globalization;

namespace EstaticMembers
    {
    class Program
        {

        
        static void Main(string[] args)
            {
            Calc Circ1;

            Circ1 = new Calc();

            Console.WriteLine("Entre com o valor do Raio: ");
            double raio = double.Parse(Console.ReadLine());           

            Console.WriteLine($"Circunferencia: {Calc.Circunferencia(raio).ToString("F2", CultureInfo.InvariantCulture)}");         

            Console.WriteLine($"Volume: {Calc.Volume(raio).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Pi:{Calc.Pi.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        
        }
    }
