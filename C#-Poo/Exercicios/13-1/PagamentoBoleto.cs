using System;

class PagamentoBoleto : Pagamento
{
    public override void ProcessarPagamento(double valor)
    {
        System.Console.WriteLine(
            $"Pagamento efetuado com sucesso no valor de {valor:C} lembrando que o mesmo leva 3 dias para compensação"
        );
    }
}
