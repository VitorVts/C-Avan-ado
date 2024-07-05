using System;

public class Empregado
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public double Salario { get; set; }

    public Empregado(string nome, int idade, double salario)
    {
        Nome = nome;
        Idade = idade;
        Salario = salario;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Salário: {Salario:C}");
    }
}
