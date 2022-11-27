using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine($"Quantas horas voce trabalhou esse mes,{nome}?");
            double numHoras = double.Parse(Console.ReadLine());
            Console.WriteLine($"Qual o valor da sua hora, {nome}?");
            double valorHora = double.Parse(Console.ReadLine());

            double salario = valorHora * numHoras;
            string textoSalario = salario.ToString("F2");

            Console.WriteLine($"{nome} , o seu salario esse mes deveria ser {textoSalario}");
         
            Console.ReadLine();
        }
    }
}
