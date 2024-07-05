using System;

class Carro : Veiculo
{
    public int NumeroDePortas;

    public Carro(string marca, string modelo, int ano, int numeroDePortas)
        : base(marca, modelo, ano)
    {
        NumeroDePortas = numeroDePortas;
    }

    public void ExibirInformacoesCarro()
    {
        ExibirInformacoes();
        Console.WriteLine($"Número de Portas: {NumeroDePortas}");
    }
}
