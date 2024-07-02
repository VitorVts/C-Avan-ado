namespace _30_Validação_De_Dados;

class Program
{
    public class Aluno
    {
        public string nome;
        int idade;
        double notaFinal;

        public Aluno(string n)
        {
            nome = n;
            idade = 18;
            notaFinal = 0;
        }

        public Aluno(string n, int i, double nt)
        {
            if (i <= 0 || i > 100)
            {
                throw new ArgumentException("A idade deve estar entre 1 e 100.");
            }
            if (nt < 0 || nt > 100)
            {
                throw new ArgumentException("A nota final deve estar entre 0 e 100.");
            }
            nome = n;
            idade = i;
            notaFinal = nt;
        }

        public void ExibirInformacao()
        {
            System.Console.WriteLine("O Nome do Aluno é ..: {0}", nome);
            System.Console.WriteLine("Idade: {0}", idade);
            System.Console.WriteLine("A Nota final é ..:{0}", notaFinal);
        }
    }

    static void Main(string[] args)
    {
        try
        {
            Aluno A1 = new Aluno("vitor");
            Aluno A2 = new Aluno("CSHORPIO", 18, 100);

            A1.ExibirInformacao();
            A2.ExibirInformacao();
        }
        catch (ArgumentException e)
        {
            System.Console.WriteLine("Erro ao Criar aluno:" + e.Message);
        }
    }
}
