namespace _25_ValoresUnicos;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Valores Únicos:");

        int[] valoresUnicos = ValUnico(1, 2, 3, 4, 4, 5);
        foreach (int valor in valoresUnicos)
        {
            Console.WriteLine(valor);
        }
    }

    static int[] ValUnico(params int[] n)
    {
        HashSet<int> unicos = new HashSet<int>();

        foreach (int num in n)
        {
            unicos.Add(num);
        }

        return unicos.ToArray();
    }
}
