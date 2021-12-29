using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string TextoCodificado = String.Empty;
            string Texto;
            string[] Alfabeto = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            Console.WriteLine("Digite o texto");
            Texto = Console.ReadLine();
            Texto = Texto.ToUpper();

            for (int i = 0; i < Texto.Length; i++)
            {
                if (Alfabeto.Contains(Texto[i].ToString()))
                {
                    var index = Array.IndexOf(Alfabeto, Texto[i].ToString());
                    var Tamanho = Alfabeto.Length;
                    if (index >= 24)
                    {
                        if((Tamanho - index) > 1 )
                        TextoCodificado = TextoCodificado + Alfabeto.ElementAt(0);

                        else
                        TextoCodificado = TextoCodificado + Alfabeto.ElementAt(Tamanho - index);
                        
                    }
                    else
                        TextoCodificado = TextoCodificado + Alfabeto.ElementAt(index - 2);

                }

            }

            Console.WriteLine(TextoCodificado);

            Console.ReadKey();
        }

    }
}
