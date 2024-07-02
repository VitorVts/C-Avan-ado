namespace _29_Atribuição_e_Exibição;

class Program
{
    public class Jogador
    {
        public int energia;
        public bool vivo;
        public string nome;

        //Método construtor
        public Jogador(string n)
        {
            nome = n;
            energia = 100;
            vivo = true;
        }

        ~Jogador()
        {
            System.Console.WriteLine($"Jogador{nome}Foi destruído");
        }
    }

    static void Main(string[] args)
    {
        Console.Clear();
        Jogador[] jogadores = new Jogador[5];

        for (int i = 0; i < 5; i++)
        {
            System.Console.WriteLine($"Digite o Nome do Jogador {i + 1}: ");
            string nome = Console.ReadLine();
            jogadores[i] = new Jogador(nome);
        }

        System.Console.WriteLine("\nInfo Dos Jogadores: ");
        foreach (var jogador in jogadores)
        {
            System.Console.WriteLine(
                $"Nome: {jogador.nome},Energia: {jogador.energia},vivo:{jogador.vivo}"
            );
        }
    }
}
