using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Ex2
    {
    class Aluno
        {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double CalcNotaFinal()
            {
            return Nota1 + Nota2 + Nota3;
            }
        public bool Aprovado()
            {
            if (CalcNotaFinal() >= 60)
                {
                Console.WriteLine("Aprovado");
                return true;
                }
            else
                {
                return false;
                }
            }
        public double NotaRestante()
            {
            if (Aprovado()){
                return 0.0;
                }
            else
                {
                return 60 - CalcNotaFinal();
                }
            }
        }
    }
