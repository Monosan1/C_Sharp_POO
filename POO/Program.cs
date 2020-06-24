using System;
using System.Globalization;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();


            Console.WriteLine("Entre com as medidadas do trinagulo X");
             = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidadas do triangulo Y");
             = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) /2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));
            Console.WriteLine($"Área de X = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área de Y = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            if (areaX > areaY)
            {
                Console.WriteLine("Área X é maior do a área Y");
            }
            else
            {
                Console.WriteLine("Área Y é maior que área X");
            }
        }
    }
}
