namespace _30_Construtores_Alternativos;

class Program
{
    public class Produto
    {
        public string nome;
        public double preco;
        public int estoque;

        public Produto(string n)
        {
            nome = n;
            preco = 0;
            estoque = 0;
        }

        public Produto(string n, double p, int e)
        {
            nome = n;
            preco = p;
            estoque = e;
        }

        public void ExibirInfo()
        {
            System.Console.WriteLine("Nome do Produto ..: {0}", nome);
            System.Console.WriteLine($"Preco do Produto ..: {preco:c}");
            System.Console.WriteLine("Quantidade em estoque..:{0}\n", estoque);
        }
    }

    static void Main(string[] args)
    {
        Produto notebook = new Produto("Acer");
        Produto tenis = new Produto("Air Force 1", 1000, 100);

        Console.Clear();
        notebook.ExibirInfo();
        tenis.ExibirInfo();
    }
}
