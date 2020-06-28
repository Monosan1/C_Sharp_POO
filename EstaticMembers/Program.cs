using System;
using System.Globalization;

namespace EstaticMembers
    {
    class Program
        {

        static double Pi = 3.14;
        static void Main(string[] args)
            {
            Console.WriteLine("Entre com o valor do Raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Circunferencia(raio);

            Console.WriteLine($"Circunferencia: {circ}");

            double vol = Volume(raio);

            Console.WriteLine($"Volume: {vol.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        static double Circunferencia(double r)
            {
            return 2 * Pi * r;
            }
        static double Volume(double r)
            {
            return 4 * Pi * Math.Pow(r, 3) / 3;
            }
        }
    }
