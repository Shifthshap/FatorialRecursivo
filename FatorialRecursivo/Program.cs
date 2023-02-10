using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FatorialRecursivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero para calcular o fatorial: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("O resultado da fatorial de " + num + " é " + Fatorial(num));
            Console.ReadKey();
        }

        static int Fatorial(int num)
        {
            if( num <=0 )
            {
                return 1;
            }
            
            return num * Fatorial(num - 1);
        }

        
    }
}
