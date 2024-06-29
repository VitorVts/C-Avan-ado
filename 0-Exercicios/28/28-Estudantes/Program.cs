namespace _29_Estudantes
{
    public class Estudantes
    {
        public string nome = "";
        public int matricula = 0;
        public string curso = "";
        public int[] notas = new int[5];

        public void AdicionarNota()
        {
            System.Console.WriteLine("Adicione suas 5 notas: ");
            for (int i = 0; i < notas.Length; i++)
            {
                System.Console.WriteLine($"Digite sua {i + 1}° nota:");
                notas[i] = int.Parse(Console.ReadLine());
            }
        }

        public void CalcularMedia()
        {
            int somaNota = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                somaNota += notas[i];
            }
            int media = somaNota / notas.Length;
            System.Console.WriteLine("{0}, sua média de notas é: {1}", nome, media);
        }

        public void ExibirInfo()
        {
            System.Console.WriteLine($"Bem-vindo: {nome}");
            System.Console.WriteLine($"Matrícula do Aluno: {matricula}");
            System.Console.WriteLine($"Curso Atual: {curso}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Estudantes id1 = new Estudantes()
            {
                nome = "Vitor",
                matricula = 1,
                curso = "Análise de Sistemas"
            };

            Estudantes id2 = new Estudantes()
            {
                nome = "Gabriela",
                matricula = 2,
                curso = "Fisioterapia"
            };

            Estudantes id3 = new Estudantes()
            {
                nome = "Balta",
                matricula = 3,
                curso = "C# POO"
            };

            Console.Clear();
            System.Console.WriteLine(
                "Digite o número de matrícula que deseja atendimento (1, 2, 3): "
            );
            int matriculaAluno = int.Parse(Console.ReadLine());

            Estudantes estudanteSelecionado = null;
            if (matriculaAluno == 1)
            {
                estudanteSelecionado = id1;
            }
            else if (matriculaAluno == 2)
            {
                estudanteSelecionado = id2;
            }
            else if (matriculaAluno == 3)
            {
                estudanteSelecionado = id3;
            }
            else
            {
                System.Console.WriteLine("Matrícula inválida");
                return;
            }

            estudanteSelecionado.ExibirInfo();
            estudanteSelecionado.AdicionarNota();
            estudanteSelecionado.CalcularMedia();
        }
    }
}
