using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPedro
{
    class Program
    {
        // ||
        static void Main(string[] args)
        {

            Condicoes();
            Console.ReadKey();
            Condicoes();
            Console.ReadKey();
        }
        public static void Condicoes()
        {
            int a = 0, b = 0, c = 0, d = 0;
            string nome = string.Empty;
            int media = 0;
            //a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do cara:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a nota 1 do aluno");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 2 do aluno");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 3 do aluno");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 4 do aluno");
            d = int.Parse(Console.ReadLine());

            media = (a + b + c + d) / 4;
            if (media != 6 && media <= 6)
                Console.WriteLine($"O aluno: {nome} foi reprovado com média: {media}");
            else
            {
                if (media > 6)
                    Console.WriteLine($"O aluno: {nome} foi aprovado com média: {media}");
                else
                    Console.WriteLine($"O aluno: {nome} foi recuperação com média: {media}");

            }
        }
    }
  

}
