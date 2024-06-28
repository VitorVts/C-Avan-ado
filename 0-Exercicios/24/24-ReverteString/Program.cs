namespace _24_ReverteString;

class Program
{
    static void Main(string[] args)
    {
        string texto = "ALO";

        string reverse = ReverterString(texto);
        Console.Clear();
        System.Console.WriteLine(reverse);
    }

    static string ReverterString(string texto)
    {
        // minha solução
        // string reverse = "";
        // foreach (char c in texto.ToCharArray())
        // {
        //     reverse = c + reverse;
        // }
        // return reverse;
        //solução mais certa
        char[] array = texto.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }
}
