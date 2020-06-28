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

            Console.WriteLine($"Circunferencia: {Circ1.Circunferencia(raio).ToString("F2", CultureInfo.InvariantCulture)}");         

            Console.WriteLine($"Volume: {Circ1.Volume(raio).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Pi:{Circ1.Pi.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        
        }
    }
