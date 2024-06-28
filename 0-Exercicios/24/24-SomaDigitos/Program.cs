namespace _24_SomaDigitos
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 12345;
            int somaDosDigitos = SomarDigitos(N);
            Console.WriteLine("A soma dos dígitos de {0} é {1}", N, somaDosDigitos);
        }

        public static int SomarDigitos(int numero)
        {
            int soma = 0;

            while (numero != 0)
            {
                soma += numero % 10;
                System.Console.WriteLine(soma);
                numero /= 10;
            }

            return soma;
        }
    }
}
