namespace _24_MaiorNoArray;

class Program
{
    static void Main(string[] args)
    {
        int[] vetor = { 10, 20, 30, 40, 50 };

        int res = Maior(vetor);

        System.Console.WriteLine($"O Maior Valor no vetor é : {res}");
    }

    static int Maior(int[] vetor)
    {
        int maior = int.MinValue;
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] > maior)
            {
                maior = vetor[i];
            }
        }
        return maior;
    }
}
