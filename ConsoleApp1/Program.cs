using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {  
        static string geraemail(string nome, string sobrenome, int idade)
        {

            string Email;
            Email = $"{nome.Substring(0, 1)}{sobrenome}{idade}@gmail.com";
            return Email;
        }
        static void Main(string[] args)
         
        {
            
            int Idade;
            string Nome, Sobrenome;
            
            Console.WriteLine("digite seu nome");
            Nome = Console.ReadLine();

            
            Console.WriteLine("digite seu sobrenome");
            Sobrenome = Console.ReadLine();

            Console.WriteLine("digite sua idade");
            Idade = int.Parse(Console.ReadLine());


            Console.WriteLine("O seu Email é: {0}", geraemail(Nome, Sobrenome, Idade));
            Console.ReadKey();
         
        }
    }
}
