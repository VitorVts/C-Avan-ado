using System;

class PagamentoPix : Pagamento
{
    public override void ProcessarPagamento(double valor)
    {
        System.Console.WriteLine(
            $"Pagamento efetuado com sucesso no valor de {valor:C} recebimento imediato"
        );
    }
}
