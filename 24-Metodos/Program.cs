namespace _24_Metodos;

class Program
{
    static void Main(string[] args)
    {
        cfb();
        int r = soma(10, 5);
        System.Console.WriteLine($"A SOMA DE  : {r} ");
    }

    static void cfb()
    {
        Console.WriteLine("CFB CURSO");
    }

    static int soma(int n1, int n2)
    {
        int res = n1 + n2;

        return res;
    }
}
