using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace couser1
{
    class Produto

    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;

        }

        public void Adicionar(int quantidade)
        {
            Quantidade += quantidade; 
        }

        public void Remover(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome + " $ "
                + Preco.ToString("F3",CultureInfo.InvariantCulture) 
                + " quantidade em estoque: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
