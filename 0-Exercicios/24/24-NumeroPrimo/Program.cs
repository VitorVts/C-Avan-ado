using System;

namespace NumeroPrimo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int N;
            System.Console.WriteLine("Digite um numero para saber se ele é primo ou não");
            while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
            {
                Console.WriteLine("Digite um numero válido");
            }
            ;
            bool valui = Primo(N);
            System.Console.WriteLine(valui);
        }

        public static bool Primo(int N)
        {
            if (N <= 1)
            {
                return false;
            }

            for (int i = 2; i < Math.Sqrt(N); i++)
            {
                if (N % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
