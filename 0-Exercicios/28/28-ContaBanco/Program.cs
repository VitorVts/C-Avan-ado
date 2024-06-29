namespace _28_ContaBanco
{
    public class ContaBancaria
    {
        public int numeroConta = 0;
        public string titular = "";
        public double saldo = 0;
        public bool ativa = false;

        public void Depositar()
        {
            double deposito = 0;
            Console.Clear();
            Console.WriteLine("Digite o valor que você deseja depositar:");
            deposito = double.Parse(Console.ReadLine());
            saldo += deposito;
            Console.WriteLine("Depósito realizado com sucesso. Novo saldo: {0}", saldo);
        }

        public void Sacar()
        {
            double saque = 0;
            Console.Clear();
            Console.WriteLine("\nSaldo disponível para saque: {0}", saldo);
            do
            {
                Console.WriteLine(
                    "Digite um valor para sacar (maior que 0 e menor ou igual ao saldo):"
                );
            } while (
                !double.TryParse(Console.ReadLine(), out saque) || saque <= 0 || saque > saldo
            );

            saldo -= saque;
            Console.WriteLine("Saque realizado com sucesso. Novo saldo: {0}", saldo);
        }

        public void ExibirSaldo()
        {
            Console.Clear();
            Console.WriteLine("Titular: {0}", titular);
            Console.WriteLine("Saldo atual: {0}", saldo);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria id1 = new ContaBancaria
            {
                numeroConta = 1,
                titular = "Vitor",
                saldo = 1000,
                ativa = true
            };

            ContaBancaria id2 = new ContaBancaria
            {
                numeroConta = 2,
                titular = "Gabriela",
                saldo = 1000,
                ativa = true
            };

            Console.WriteLine("Digite o número da conta que deseja atendimento (1 ou 2):");
            int numeroConta = int.Parse(Console.ReadLine());

            ContaBancaria contaSelecionada = null;
            if (numeroConta == 1)
            {
                contaSelecionada = id1;
            }
            else if (numeroConta == 2)
            {
                contaSelecionada = id2;
            }
            else
            {
                Console.WriteLine("Número de conta inválido.");
                return;
            }

            string option;
            do
            {
                Console.WriteLine(
                    "\nSelecione a operação: D (Depositar), S (Sacar), E (Exibir saldo), X (Sair):"
                );
                option = Console.ReadLine().ToUpper();

                switch (option)
                {
                    case "D":
                        contaSelecionada.Depositar();
                        break;
                    case "S":
                        contaSelecionada.Sacar();
                        break;
                    case "E":
                        contaSelecionada.ExibirSaldo();
                        break;
                    case "X":
                        Console.WriteLine("Encerrando o atendimento.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            } while (option != "X");
        }
    }
}
