using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteCartesiano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a cordenada X");
            int x = int.Parse(Console.ReadLine();
            Console.WriteLine("Digite a cordenada Y");
            int y = int.Parse(Console.ReadLine();

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (y == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }

            Console.ReadLine(); 
        }
    }
}
