using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Inicio:
            Console.Clear();

            int a = 0, b = 1, c = 0;

            System.Console.Write("Quantos valores: ");
            int valores = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Sequência de Fibonacci com " + valores + " valores");

            for (int i = 0; i < valores; i++)
            {
                if (i < valores - 1)
                {
                    System.Console.Write(a + ", "); 
                }
                else
                {
                    System.Console.Write(a);
                }                

                c = a + b;
                a = b;
                b = c;
            }
            System.Console.Write("\n\nContinuar (s / n) ? ");
            string opcao = Console.ReadLine();

            if (opcao == "s" || opcao == "S")
            {
                goto Inicio;
            }
        }
    }    
}
