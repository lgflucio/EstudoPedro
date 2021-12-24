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
            for (int i = 2; i < 1000; i++)
            {
            calculaNumeroPrimo(i);
            }
            Console.ReadKey();
        }
        public static string calculaNumeroPrimo(int n)
        {
            string resultado = n.ToString();
         
                for (int i = 2; i < n; i++)
                {
                    int resto = n % i;
                    if (resto == 0)
                    {
                        resultado = n + " não primo";
                        i = n + 1;
                    }
                    else
                        resultado = n + " primo";
                }
            
           
            Console.WriteLine(resultado);

            return resultado;
        }
    }
}
