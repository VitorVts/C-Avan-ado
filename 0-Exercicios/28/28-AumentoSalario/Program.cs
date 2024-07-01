namespace _28_AumentoSalario
{
    public class Funcionario
    {
        public string nome = "";
        public string cpf = "";
        public string cargo = "";
        public double salario = 0;

        public void AumentarSalario()
        {
            double aumento = 0;
            do
            {
                Console.WriteLine("Digite o valor de aumento para {0} (maior que 0):", nome);
            } while (!double.TryParse(Console.ReadLine(), out aumento) || aumento <= 0);

            salario += aumento;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("Dados do funcionário:");
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("CPF: {0}", cpf);
            Console.WriteLine("Cargo: {0}", cargo);
            Console.WriteLine("Salário: {0:C}", salario);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Funcionario vitor = new Funcionario
            {
                nome = "Vitor Gomes Guimarães",
                cpf = "000.000.000-00",
                cargo = "Desenvolvedor",
                salario = 2000
            };
            Funcionario gabriela = new Funcionario
            {
                nome = "Gabriela Gomes Guimarães",
                cpf = "000.000.000-00",
                cargo = "Fisioterapeuta",
                salario = 2000
            };

            Funcionario funcSelected = null;

            Console.WriteLine("Digite o nome do funcionário (vitor) ou (gabriela): ");
            string select = Console.ReadLine().ToLower();

            if (select == "gabriela")
            {
                funcSelected = gabriela;
            }
            else if (select == "vitor")
            {
                funcSelected = vitor;
            }
            else
            {
                Console.WriteLine("Funcionário inválido. Digite novamente.");
                return;
            }

            Console.Clear();
            funcSelected.ExibirInformacoes();
            funcSelected.AumentarSalario();
            Console.Clear();
            Console.WriteLine("Atualização:");
            funcSelected.ExibirInformacoes();
        }
    }
}
