using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificarNumeroPar
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            bool Primo = false;
            int aux = 0;
            for (int i = 1; i <= 1000; i = i + 1)
            {
                aux = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % 2 == 0)
                        continue;
                    if (i % j == 0)
                        aux++;
                    else
                        continue;
                }

                if(aux==1 && i==1)
                    Console.WriteLine($"{i} Primo");
                if (aux==2)
                    Console.WriteLine($"{i} Primo");
               
            }

            Console.ReadKey();
        }
    }
}

//Numero = int.Parse(Console.ReadLine());

//Console.WriteLine("{0}", Numero / 2);
//r = Numero / 2;

//r = r * 2;

//Resto = r < Numero;

//if (!Resto)
//{
//    Console.WriteLine("par");
//}
//else
//{
//    Console.WriteLine("impar");
//}