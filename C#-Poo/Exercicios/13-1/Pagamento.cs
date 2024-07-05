using System;

class Pagamento
{
    public virtual void ProcessarPagamento(double valor)
    {
        System.Console.WriteLine($"o valor pago foi {valor:C}");
    }
}
