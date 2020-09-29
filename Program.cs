using System;
using System.Globalization;
using System.Globalization;
using System.Security.Cryptography;

namespace ExercicioPessoaMaisVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa P1, P2;
            P1 = new Pessoa();
            P2 = new Pessoa();

            Console.WriteLine("Digite o nome da primeira pessoa:");
            P1.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da primeira pessoa:");
            P1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da segunda pessoa:");
            P2.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da segunda pessoa:");
            P2.Idade = int.Parse (Console.ReadLine());

            if (P1.Idade > P2.Idade) 
            {
                Console.WriteLine("A pessoa mais velha é {0}", P1.Nome);
            }
            else
            {
                Console.WriteLine("A pessoa mais velha é {0}", P2.Nome);
            }
            Console.ReadKey();
        }
    }
}
