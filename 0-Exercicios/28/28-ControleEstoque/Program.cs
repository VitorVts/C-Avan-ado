namespace _28_ControleEstoque;

public class Produto
{
    public int codigo = 0;
    public string nomeProduto = "";
    public int quantidade = 0;
    public double preco = 0;

    public void AdicionarEstoque()
    {
        System.Console.WriteLine("Digite a quantidade de {0} a ser adicionado", nomeProduto);
        quantidade += int.Parse(Console.ReadLine());

        System.Console.WriteLine($"{0} agora tem {quantidade} no estoque", nomeProduto);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Produto celular = new Produto
        {
            codigo = 0,
            nomeProduto = "Iphone11",
            quantidade = 1,
            preco = 1500.00
        };
        Produto notebook = new Produto
        {
            codigo = 0,
            nomeProduto = "Lenovo yoga",
            quantidade = 1,
            preco = 1500.00
        };

        celular.AdicionarEstoque();
    }
}
