using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace couser2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite um valor:");
            double? x = double.Parse(Console.ReadLine());

            Console.WriteLine("digite um valor:");
            double? y = double.Parse(Console.ReadLine());

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is null");
            }
            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
            }
        }
    }
}
