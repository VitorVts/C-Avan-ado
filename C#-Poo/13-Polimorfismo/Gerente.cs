using System;

class Gerente : Imposto
{
    //Metodo

    public override void valeAlimentacao(double salario)
    {
        System.Console.WriteLine($"Desconto gerente do vale alimentacao {salario * 0.15}");
    }
}
