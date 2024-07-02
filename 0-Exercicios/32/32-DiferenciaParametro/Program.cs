namespace _32_DiferenciaParametro;

class Program
{
    class Pessoa
    {
        public string nome;
        public int idade;

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public void ExibirInformacao()
        {
            System.Console.WriteLine("Nome: {0}", nome);
            System.Console.WriteLine("Idade: {0}", idade);
        }
    }

    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa("VITOR", 24);
        p1.ExibirInformacao();
    }
}
