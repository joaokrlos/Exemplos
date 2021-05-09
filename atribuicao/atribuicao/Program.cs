using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace atribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "maria";
            string profissao = "desenvolvedor";
            string empresa = "sam";
            double salario = 1.200;
            int idade = 25;

            Console.WriteLine($"{nome} tem {idade} anos de idade, trabalha na empresa {empresa} como {profissao} e ganha {salario:F3} reais por mes ");
            Console.WriteLine("------------------------------------------------------------------------");
            nome += " da silva santos";
            profissao += " de sistemas";
            empresa += "sung";
            salario *= 3;
            idade += 2;

            Console.WriteLine("{0} tem {1} anos de idade , trabalha na empresa {2} como {3} e ganha {4:F3} reais por mês" ,nome,idade,empresa,profissao,salario );
            Console.WriteLine("--------------------------------------------------------------------------");
            nome = "carlos droumont";
            profissao = "analista";

            Console.WriteLine(nome +" tem "+idade+" anos de idade , trabalha na empresa "+empresa+ " como "+profissao+" e ganha "+ salario.ToString("F3", CultureInfo.InvariantCulture)+ " reais por mes");



        }
    }
}
;