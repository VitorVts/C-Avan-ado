using System;

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int QntEstoque { get; set; }

    public Produto(string nome, double preco, int Quant)
    {
        Nome = nome;
        Preco = preco;
        QntEstoque = Quant;
    }

    public void ExibirProduto()
    {
        System.Console.WriteLine(
            $"Nome do Produto:{Nome},Preço: {Preco:C}\nQuantidade em Estoque: {QntEstoque}"
        );
    }

    public int AdicionarEstoque(int quantidade)
    {
        QntEstoque += quantidade;
        System.Console.WriteLine($"{Nome} tem agora {QntEstoque} em estoque");
        return QntEstoque;
    }

    public int RemoverEstoque(int quantidade)
    {
        QntEstoque -= quantidade;
        System.Console.WriteLine($"{Nome} tem agora {QntEstoque} em estoque");
        return QntEstoque;
    }
}
