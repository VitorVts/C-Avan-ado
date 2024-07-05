using System;

class ProdutoEletronico : Produto
{
    public string Marca;
    public string Voltagem;

    public ProdutoEletronico(
        string nome,
        double preco,
        int QntEstoque,
        string marca,
        string voltagem
    )
        : base(nome, preco, QntEstoque)
    {
        Marca = marca;
        Voltagem = voltagem;
    }

    public void ExibirProdutoEletronico()
    {
        ExibirProduto();
        System.Console.Write($"Marca: {Marca} Voltagem: {Voltagem}");
    }

    public string DefinirVoltagem(string voltagem)
    {
        Voltagem = voltagem;
        System.Console.WriteLine($"Voltagem definida para: {Voltagem}");
        return Voltagem;
    }
}
