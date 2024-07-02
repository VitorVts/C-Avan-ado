namespace _29_Construtores_e_Destrutores;

public class Jogador
{
    public int energia;
    public bool vivo;
    public string nome;

    //metodo construtor
    public Jogador(string n)
    {
        nome = n;
        energia = 100;
        vivo = true;
    }

    //metodo destrutor
    ~Jogador()
    {
        System.Console.WriteLine("Jogador foi destruido", nome);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Jogador j1 = new Jogador("Vitor Gomes");
        Jogador j2 = new Jogador("Vini Junior");
        Jogador j3 = new Jogador("Xampson Csharp da Silva");

        Console.Clear();
        System.Console.WriteLine("Nome: {0}, Energia: {1},Vivo:{2}", j1.nome, j1.energia, j1.vivo);
        System.Console.WriteLine("Nome: {0}, Energia: {1},Vivo:{2}", j2.nome, j2.energia, j2.vivo);
        System.Console.WriteLine("Nome: {0}, Energia: {1},Vivo:{2}", j3.nome, j3.energia, j3.vivo);

        
    }
}
