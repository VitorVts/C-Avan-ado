using System;

class Moto : Veiculo
{
    public int Cilindradas;

    public Moto(string marca, string modelo, int ano, int cilindradas)
        : base(marca, modelo, ano)
    {
        Cilindradas = cilindradas;
    }

    public void ExibirInformacoesMoto()
    {
        ExibirInformacoes();
        System.Console.WriteLine($"Cilindradas:{Cilindradas}");
    }
}
