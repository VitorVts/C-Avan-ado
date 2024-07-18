using System;

public class ContaBancaria
{
    public string NumeroConta;
    public string Titular;
    public double Saldo;

    public ContaBancaria(string NumeroConta, string Titular, double Saldo)
    {
        this.NumeroConta = NumeroConta;
        this.Titular = Titular;
        this.Saldo = Saldo;
    }

    public void Depositar(double deposito)
    {
        Saldo += deposito;
        System.Console.WriteLine($"Seu Saldo Total pós deposito é {Saldo:C}");
    }

    public void Sacar(double saque)
    {
        Saldo -= saque;
        System.Console.WriteLine($"Seu Saldo Total pós Saque é : {Saldo:C}");
    }

    public void ExibirSaldo()
    {
        System.Console.WriteLine($" Seu Saldo atual é : {Saldo:C}");
    }
}
