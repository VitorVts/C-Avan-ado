using System;

public class Gerente : Empregado
{
    public string Setor;

    public Gerente(string nome, int idade, double salario, string setor)
        : base(nome, idade, salario)
    {
        Setor = setor;
    }

    public double CalcularBonus()
    {
        return Salario * 0.20;
    }

    public void ExibirInformacoesGerente()
    {
        ExibirInformacoes();
        System.Console.WriteLine($"Setor: {Setor}");
        System.Console.WriteLine($"Bonús: {CalcularBonus():C}");
    }
}
