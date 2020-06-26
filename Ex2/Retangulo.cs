using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Ex2
    {
    class Retangulo
        {
        public double Largura;
        public double Altura;

        public double Area()
            {
            return Largura*Altura;
            }
        public double Perimetro()
            {
            return 2 * (Largura + Altura);
            }
        public double Diagonal()
            {
            double LarguraMath = Math.Pow(Largura, 2);
            double AlturaMath = Math.Pow(Altura, 2);

            double RaizQuadrada = Math.Sqrt(LarguraMath + AlturaMath);
            return RaizQuadrada;
            }
        }
    }
