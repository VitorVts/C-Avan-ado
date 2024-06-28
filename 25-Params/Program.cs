namespace _25_Params;

class Program
{
    static void Main(string[] args)
    {
        soma(1, 2, 3);
    }

    static void soma(params int[] n)
    {
        int res = 0;

        if (n.Length < 1)
        {
            System.Console.WriteLine("Não existem valores a serem somados");
        }
        else if (n.Length < 2)
        {
            System.Console.WriteLine(
                n.Length + "Não existem valores a suficientes para soma: {0}",
                n[0]
            );
        }
        else
        {
            for (int i = 0; i < n.Length; i++)
            {
                res += n[i];
            }
            System.Console.WriteLine("A soma dos valores é : {0}", res);
        }
    }
}
