using System;

class Pessoa
{
    //Atributo
    private string nome = "tatiana";

    //Construtor
    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome);
    }
}
