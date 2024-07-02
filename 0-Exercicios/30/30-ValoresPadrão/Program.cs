namespace _30_ValoresPadrao
{
    public class Livro
    {
        public string titulo;
        public string autor;
        public int paginas;

        public Livro(string t)
        {
            titulo = t;
            autor = "Indefinido";
            paginas = 0;
        }

        public Livro(string t, string a)
        {
            titulo = t;
            autor = a;
            paginas = 0;
        }

        public Livro(string t, string a, int p)
        {
            titulo = t;
            autor = a;
            paginas = p;
        }

        public void ExibirInformacoes()
        {
            System.Console.WriteLine("Acervo de livros Do Vitor");
            System.Console.WriteLine("Título do Livro..: {0}", titulo);
            System.Console.WriteLine("Autor do Livro..: {0}", autor);
            System.Console.WriteLine("Quantidade de Páginas..: {0}\n", paginas);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Livro l1 = new Livro("A Revolução dos Bichos");
            Livro l2 = new Livro("Hooked: Como Construir Produtos", "Nir Eyal");
            Livro l3 = new Livro(
                "Entendendo Algoritmos: Um Guia Ilustrado Para Programadores e Outros Curiosos",
                "Aditya Y. Bhargava",
                400
            );

            l1.ExibirInformacoes();
            l2.ExibirInformacoes();
            l3.ExibirInformacoes();
        }
    }
}
