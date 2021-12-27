using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int Combustivel = 12;
            int Tempo;
            int Velocidade;
            double Distancia;
            double Gasto;
            int Tempo2;

            Console.WriteLine("Quantas horas de viagem?:");
            Tempo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira a velocidade média:");
            Velocidade = Convert.ToInt32(Console.ReadLine());

            Tempo2 = Tempo / 60
            Distancia = Velocidade * Tempo;

            Gasto = Distancia / Combustivel;

            Console.WriteLine($"A distancia percorrida é de: {Distancia} Kilometros");
            Console.WriteLine($"O seu gasto de combustivel será de: {Gasto}");
            Console.ReadKey();







        }
    }
}
