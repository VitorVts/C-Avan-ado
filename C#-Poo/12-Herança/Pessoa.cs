using System;

class Pessoa
{
    //atributos
    protected string nome;
    protected int idade;

    //metodo
    protected void mensagemPessoa()
    {
        System.Console.WriteLine($"Nome : {nome}");
        System.Console.WriteLine($"idade : {idade}");
    }
}
