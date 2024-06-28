namespace _25_NomesOrdemAlfabetica;

class Program
{
    static void Main(string[] args)
    {
        string[] nomesOrdenados = OrdenaNomes("João", "Ana", "Pedro", "Beatriz", "Carlos");

        foreach (string nome in nomesOrdenados)
        {
            Console.WriteLine(nome);
        }
    }

    static string[] OrdenaNomes(params string[] nomes)
    {
        Array.Sort(nomes);
        return nomes;
    }
}
