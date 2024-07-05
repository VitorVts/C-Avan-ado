using System;

class PagamentoCartaoCredito : Pagamento
{
    public override void ProcessarPagamento(double valor)
    {
        System.Console.WriteLine(
            $"Pagamento efetuado com sucesso no cartão de crédito no valor de {valor:C} mais juros de parcela {valor * 0.2:C}"
        );
    }
}
