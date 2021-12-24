using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string Nome;
            decimal Valor = 0;

            List<Pessoa> Pessoas = new List<Pessoa>();

            while (i < 3)
            {
                i = i + 1;
                Console.Write("digite seu nome: ");
                Nome = Console.ReadLine();
                Console.WriteLine();
                Console.Write("digite o valor doado: ");
                Valor = decimal.Parse(Console.ReadLine());
                Console.WriteLine();

                decimal ResultadoValor = Valor / 10;

                int VezesLista = Convert.ToInt32(ResultadoValor);

                Console.WriteLine("o participante {0} doou {1} reais",Nome,Valor);

                for (int j = 0; j < VezesLista; j++)
                {
                    Pessoa Pessoa = new Pessoa
                    {
                        Nome = Nome
                    };

                    Pessoas.Add(Pessoa);
                }

            }

            Random rand = new Random(DateTime.Now.Millisecond);
            Pessoa resultado = Pessoas[rand.Next(Pessoas.Count)];

            Console.WriteLine("o sorteado é:{0}", resultado.Nome);

            Console.ReadKey();
        }
    }
}
