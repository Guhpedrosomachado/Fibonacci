using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número para verificar se pertence à sequência de Fibonacci:");
            int numero = Convert.ToInt32(Console.ReadLine());

            int a = 0;
            int b = 1;
            int proximo = 0;

            if (numero == 0 || numero == 1)
            {
                Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
                return;
            }

            while (proximo < numero)
            {
                proximo = a + b;
                a = b;
                b = proximo;
            }

            if (proximo == numero)
            {
                Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
            }
            Console.ReadKey();
        }
    }
}
