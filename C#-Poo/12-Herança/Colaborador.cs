using System;

class Colaborador : Pessoa
{
    //Atributos

    private double salario;

    //construtor
    public Colaborador(string nome, int idade, double salario)
    {
        this.nome = nome;
        this.idade = idade;
        this.salario = salario;

        mensagemPessoa();
        mensagemColaborador();
    }

    private void mensagemColaborador()
    {
        System.Console.WriteLine($"Salario:{salario:c}");
    }
}
