using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por Favor informe o numero:");

            int num = Convert.ToInt32(Console.ReadLine());

            int resultado = num % 2;

            if (resultado == 1)
            {

                Console.WriteLine("o numero é impar");
            }
            else
            {
                Console.WriteLine("o numero é par");    
            }
             Console.ReadLine();
        }
    }
}
                