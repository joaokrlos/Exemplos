using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace couser1
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("entre com os dados do produto: ");
            Console.WriteLine("nome: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("quantidade estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("dados do produto: "+ p);
            Console.WriteLine();
            Console.WriteLine("digite o numero de produto a ser add no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.Adicionar(qte);
            Console.WriteLine("dados atualizados: "+p);
            Console.WriteLine();
            Console.WriteLine("digite o numero de produtos a ser removido: ");
            qte = int.Parse(Console.ReadLine());
            p.Remover(qte);
            Console.WriteLine("dados atualizados: " + p);





        }
    }
}
