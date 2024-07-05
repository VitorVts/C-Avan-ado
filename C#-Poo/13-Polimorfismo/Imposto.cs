using System;

class Imposto
{
    //Métodos
    public virtual void valeAlimentacao(double salario)
    {
        System.Console.WriteLine($"Desconto Padrão do Vale Alimentação {salario * 0.1:C}");
    }

    public virtual void valeTransporte(double salario)
    {
        System.Console.WriteLine($"Desconto Padrão do Vale Transporte {salario * 0.06:C}");
    }
}
