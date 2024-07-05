using System;

class Atendente : Imposto
{
    public void valeAlimentacao(double salario)
    {
        System.Console.WriteLine($"Desconto Atendente do vale alimentacao {salario * 0.15}");
    }
}
