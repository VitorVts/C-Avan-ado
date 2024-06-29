namespace _28_Classes_e_Objetos;

public class Jogador
{
    public int energia = 100;
    public bool vivo = true;
}

class Program
{
    static void Main(string[] args)
    {
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador();
        Jogador j3 = new Jogador();

        j1.energia = 50;

        System.Console.WriteLine("eENERGIA DO JOGADOR 1 : {0}", j1.energia);
        System.Console.WriteLine("eENERGIA DO JOGADOR 1 : {0}", j2.energia);
    }
}
