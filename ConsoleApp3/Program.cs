 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
             double Valor;
            double Nota100, Nota50, Nota20, Nota10, Nota5, Moeda100, Moeda50, Moeda25, Moeda10, Moeda5, Moeda1;

            Console.WriteLine("Por Favor Insira O Valor:");
            Valor = Convert.ToDouble(Console.ReadLine());

            Nota100 = (Valor - Valor % 100) / 100;
            Valor = Valor % 100;

            if(Nota100 >= 1)
                Console.WriteLine($"{Nota100} Notas de 100 reais!");
                
            Nota50 = (Valor - Valor % 50) / 50;
            Valor = Valor % 50;

            if(Nota50 >= 1)
                Console.WriteLine($"{Nota50} Notas de 50 reais!");

            Nota20 = (Valor - Valor % 20) / 20;
            Valor = Valor % 20;

            if(Nota20 >= 1)
                Console.WriteLine($"{Nota20} Notas de 20 reais!");

            Nota10 = (Valor - Valor % 10) / 10;
            Valor = Valor % 10;

            if(Nota10 >= 1)
                Console.WriteLine($"{Nota10} Notas de 10 reais!");

            Nota5 = (Valor - Valor % 5) / 5;
            Valor = Valor % 5;

            if(Nota5 >= 1)
                Console.WriteLine($"{Nota5} Notas de 5 reais!");

            Moeda100 = (Valor - Valor % 1) / 1;
            Valor = Valor % 1;

            if(Moeda100 >= 1)
                Console.WriteLine($"{Moeda100} Moedas de 1 real!");

             Moeda50 = (Valor - Valor % 0.50) / 0.50;
            Valor = Valor % 0.50;

            if(Moeda50 >= 1)
                Console.WriteLine($"{Moeda50} Moedas de 50 centavos!");

             Moeda25 = (Valor - Valor % 0.25) / 0.25;
            Valor = Valor % 0.25;

            if(Moeda25 >= 1)
                Console.WriteLine($"{Moeda25} Moedas de 25 centavos!");

             Moeda10 = (Valor - Valor % 0.10) / 0.10;
            Valor = Valor % 0.10;

            if(Moeda10 >= 1)
                Console.WriteLine($"{Moeda10} Moedas de 10 centavos!");

             Moeda5 = (Valor - Valor % 0.05) / 0.05;
            Valor = Valor % 0.05;

            if(Moeda5 >= 1)
                Console.WriteLine($"{Moeda5} Moedas de 5 centavos!");

             Moeda1 = (Valor - Valor % 0.01) / 0.01;
            Valor = Valor % 0.01;

            if(Moeda1 >= 1)
                Console.WriteLine($"{Moeda1} Moedas de 1 centavo!");


            Console.ReadKey();
        }
    }
}
