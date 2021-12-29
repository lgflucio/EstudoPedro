using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nome = string.Empty;
            string Sobrenome = string.Empty;    
            int Idade;
            

            Console.WriteLine("Digite seu nome:");
            Nome = Console.ReadLine();

            Console.WriteLine("Digite seu sobrenome:");
            Sobrenome = Console.ReadLine();

            Console.WriteLine("Digite sua idade:");
            Idade = Convert.ToInt32(Console.ReadLine());

            Email = Nome[0] + Sobrenome + Idade;

            Console.WriteLine($"{Nome[0]}{Sobrenome}{Idade}@gmail.com");
            Console.ReadKey();








        } 
    }
}
