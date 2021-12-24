using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Area;
            double n = Math.PI;
            double Raio;


            Console.WriteLine("Insira os Dados de entrada:");
            Raio = Convert.ToDouble(Console.ReadLine());

            Area = n * (Raio * Raio);

            Console.WriteLine($"A área da cincunfêrencia é: {Area}");
            Console.ReadKey();
        }
         
    }
}
