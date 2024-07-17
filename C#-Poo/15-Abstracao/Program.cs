using System;

namespace _15Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            pf.taxaEmprestimo(1000);

            PessoaJuridica pj = new PessoaJuridica();
            pj.taxaEmprestimo(1000);
        }
    }
}
