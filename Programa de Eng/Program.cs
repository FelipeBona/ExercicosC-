using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_de_Eng
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // pergunta pela primeira bitola e atribuit o valor da variavel
            Console.WriteLine("Digite o valor da primeira bitola (mm):");
            double bitola1 = Double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);

            // pergunta pela segunda bitola e atribuit o valor da variavel
            Console.WriteLine("Digite o valor da segunda bitola (mm):");
            double bitola2 = Double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);

            // calcular o raio
            // area = pi * raio2
            double raio1 = (bitola1 / 2) / 10;
            double area1 = Math.PI * Math.Pow(raio1, 2);
            Console.WriteLine($"o valor da primeira area é {Math.Round(area1 , 2)}cm");


            // calcular o raio
            // area = pi * raio2
            double raio2 = (bitola2 / 2) / 10;
            double area2 = Math.PI * Math.Pow(raio2, 2);
            Console.WriteLine($"o valor da segunda area area é {Math.Round(area2, 2)}cm");

            //comparacao
            if (bitola1 > bitola2)
            {
                Console.WriteLine("A maior area pertence a primerira barra");
            } else if (bitola1 == bitola2){
                Console.WriteLine("as bitolas sao iguais");
            }
            else
            {
                Console.WriteLine("A maior area pertence a segunda barra");
            }
            Console.ReadLine();
            
        }
    }
}
