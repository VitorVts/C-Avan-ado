namespace _30_Sobrecarga_de_Construtor;

class Program
{
    public class Jogador
    {
        public string nome;
        public int energia;
        public bool vivo;

        public Jogador()
        {
            nome = "Jogador";
            energia = 100;
            vivo = true;
        }

        public Jogador(string n)
        {
            nome = n;
            energia = 100;
            vivo = true;
        }

        public Jogador(string n, int e)
        {
            nome = n;
            energia = e;
            vivo = true;
        }

        public Jogador(string n, int e, bool vivo)
        {
            nome = n;
            energia = e;
            vivo = true;
        }

        public void ExibInfo()
        {
            System.Console.WriteLine("Nome..: {0} ", nome);
            System.Console.WriteLine(" Energia..: {0}", energia);
            System.Console.WriteLine(" vivo..:{0}\n", vivo);
        }
    }

    static void Main(string[] args)
    {
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador("Vitor");
        Jogador j3 = new Jogador("CSharpio", 50);
        Jogador j4 = new Jogador("Xampinho", 180, false);

        Console.Clear();
        j1.ExibInfo();
        j2.ExibInfo();
        j3.ExibInfo();
        j4.ExibInfo();
    }
}
