using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de numeros para somar: ");
            int quantidadeNumeros = int.Parse(Console.ReadLine());

            int soma = 0;

            // for (inicio ; condicao ; incremento)
            for (int iterador = 1; iterador <= quantidadeNumeros; iterador++)
            {
                Console.WriteLine($"Digite o valor # {iterador}:");
                int valor = int.Parse(Console.ReadLine());
                soma = soma + valor; 
            }
            Console.WriteLine($"O valor da soma é {soma}");
            Console.WriteLine();
        }
    }
}
