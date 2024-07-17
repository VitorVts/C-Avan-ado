using System;

class PessoaJuridica : Padrao
{
    // Método Obrigatorio
    public override void taxaEmprestimo(double valor)
    {
        System.Console.WriteLine($"Taxa de Empréstimo para Pessoa Jurídica : R${valor * 0.2}");
    }
}
