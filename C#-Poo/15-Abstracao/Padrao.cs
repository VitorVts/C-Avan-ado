using System;

abstract class Padrao
{
    //Obrigatorio
    public abstract void taxaEmprestimo(double valor);

    //Opcional
    public void calculoPoupanca(double valor, double taxa)
    {
        System.Console.WriteLine($"Ganhos Obtidos pela Poupança : R${valor * taxa}:C");
    }
}
