using System;

public class Carro
{
    public string Marca;
    public string Modelo;

    public int Ano;
    public double VelocidadeAtual;

    public Carro(string Marca, string Modelo, int Ano, double VelocidadeAtual)
    {
        this.Marca = Marca;
        this.Modelo = Modelo;
        this.Ano = Ano;
        this.VelocidadeAtual = VelocidadeAtual;
    }

    public void Acelerar()
    {
        VelocidadeAtual += 10;
        System.Console.WriteLine($"Velocidade atual:{VelocidadeAtual}");
    }

    public void Frear()
    {
        VelocidadeAtual -= 10;
        if (VelocidadeAtual < 0)
            VelocidadeAtual = 0;
        System.Console.WriteLine($"Velocidade atual : {VelocidadeAtual}");
    }

    public void ShowInformation()
    {
        System.Console.WriteLine(
            $"Marca:{Marca},Modelo:{Modelo},Ano:{Ano},Velocidade Atual:{VelocidadeAtual}"
        );
    }
}
