using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Construtores
    {
    class Produto
        {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
            {
            Quantidade = 10;
            }

        public Produto(string nome, double preco, int quantidade)
            {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            }

        public string Nome { 
            get { return _nome; }
            set {
                if (value != null && value.Length > 1)
                    {
                    _nome = value;
                    }
                }
            }
            
            
       

       

        /* public Produto(string nome, double preco,) : this(nome, preco)
             {
             Quantidade = quantidade;
             }
 */
        public double ValorTotalEmEstoque()
            {
            return Preco *Quantidade;
            }

        public void AdicionarProdutos(int quantidade)
            {
            Quantidade += quantidade;
            }

        public void RemoverProdutos(int quantidade)
            {
            Quantidade -= quantidade;
            }

        public override string ToString()
            {
            return _nome + ", R$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " Unidades, Total: R$"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
            }



        }
    }
