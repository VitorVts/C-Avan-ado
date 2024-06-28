// Exercício 1: Contagem de Números Ímpares
// Crie um método que receba uma quantidade variável de inteiros e retorne quantos desses números são ímpares.


namespace _25_ContaImpares;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        ContaImpar(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
    }

    public static void ContaImpar(params int[] n)
    {
        int impares = 0;

        for (int i = 0; i < n.Length; i++)
        {
            if (n[i] % 2 != 0)
            {
                impares++;
            }
        }
        // implementação mais prática
        // foreach (int numero in n)
        // {
        //     if (numero % 2 != 0)
        //     {
        //         impares++;
        //     }
        // }

        System.Console.WriteLine("A Quatidade de números impares é : {0}", impares);
    }
}
