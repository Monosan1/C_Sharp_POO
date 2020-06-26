using System;
using System.Globalization;

namespace Ex2
    {
    class Program
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
        }

    class EX2
        {
        static void main(string[] args)
            {

            }
        }
    }
