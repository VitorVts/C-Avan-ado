using System;

class PessoaFisica : Padrao
{
    // Método Obrigatorio
    public override void taxaEmprestimo(double valor)
    {
        System.Console.WriteLine($"Taxa de Empréstimo para Pessoa Física : R${valor * 0.1}");
    }
}
