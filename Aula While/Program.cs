using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            double x = Double.Parse(Console.ReadLine());
            
            while(x >= 0)
            {
                double resposta = Math.Sqrt(x);
                Console.WriteLine(resposta.ToString("F2", CultureInfo.InvariantCulture));
                Console.Write("Digite outro numero: ");
                x = Double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Nao foi possivel calcular. O numero é negativo ");
            Console.ReadLine();
        }
    }
}
