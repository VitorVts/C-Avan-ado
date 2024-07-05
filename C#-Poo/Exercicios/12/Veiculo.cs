using System;

class Veiculo
{
    protected string Marca;
    protected string Modelo;
    protected int Ano;

    public Veiculo(string marca, string modelo, int ano)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}");
    }
}
