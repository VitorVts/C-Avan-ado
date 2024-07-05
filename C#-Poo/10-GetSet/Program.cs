using System;

namespace _08_GetSet;

class Program
{
    static void Main(string[] args)
    {
        Pessoa p = new Pessoa();

        p.Nome= "Vitor";

        System.Console.WriteLine(p.Nome);
    }
}
