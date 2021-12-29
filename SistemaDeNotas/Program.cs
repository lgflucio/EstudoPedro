using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeNotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Nota100, Nota50, Nota20, Nota10, Nota5;
            int Valor;

            Console.WriteLine("Digite o valor para saque:");
            Valor = Convert.ToInt32(Console.ReadLine());

            Nota100 = (Valor - Valor % 100) / 100;
            Valor = Valor % 100;

            Nota50 = (Valor - Valor % 50) / 50;
            Valor = Valor % 50;

            Nota20 = (Valor - Valor % 20) / 20;
            Valor = Valor % 20;

            Nota10 = (Valor - Valor % 10) / 10;
            Valor = Valor % 10;

            Nota5 = (Valor - Valor % 5) / 5;
            Valor = Valor % 5;

            Console.WriteLine($"{Nota100} Notas de 100 reais");
            Console.WriteLine($"{Nota50} Notas de 50 reais");
            Console.WriteLine($"{Nota20} Notas de 20 reais");
            Console.WriteLine($"{Nota10} Notas de 10 reais");
            Console.WriteLine($"{Nota5} Notas de 5 reais");
            Console.ReadKey();
        }
    }
}
