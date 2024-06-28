using System.Runtime.ExceptionServices;

namespace _25_SomaDeMatrizes;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int[,] M1 =
        {
            { 1, 2, 3 },
            { 1, 2, 3 }
        };
        int[,] M2 =
        {
            { 1, 2, 3 },
            { 1, 2, 3 }
        };

        int[,] matrizSoma = SomaMatrizes(M1, M2);

        if (matrizSoma != null)
        {
            for (int i = 0; i < matrizSoma.GetLength(0); i++)
            {
                for (int j = 0; j < matrizSoma.GetLength(1); j++)
                {
                    System.Console.Write(matrizSoma[i, j] + "\t");
                }
                System.Console.WriteLine();
            }
        }
    }

    public static int[,] SomaMatrizes(int[,] M1, int[,] M2)
    {
        if (M1.GetLength(0) != M2.GetLength(0) || M1.GetLength(1) != M2.GetLength(1))
        {
            System.Console.WriteLine("As matrizes tem tamnho diferentes e não podem ser somadas.");
            return null;
        }

        int linhas = M1.GetLength(0);
        int colunas = M1.GetLength(1);
        int[,] matrizSoma = new int[linhas, colunas];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                matrizSoma[i, j] = M1[i, j] + M2[i, j];
            }
        }
        return matrizSoma;
    }
}
