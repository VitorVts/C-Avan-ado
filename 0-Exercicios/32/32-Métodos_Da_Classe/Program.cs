namespace _32_Métodos_Da_Classe
{
    class Program
    {
        class ContaBancaria
        {
            public double saldo;
            public double limite;

            public ContaBancaria(double saldo, double limite)
            {
                this.saldo = saldo;
                this.limite = limite;
            }

            public void Depositar(double valor)
            {
                if (valor > 0)
                {
                    this.saldo += valor;
                    System.Console.WriteLine("Depósito realizado com sucesso!");
                }
                else
                {
                    System.Console.WriteLine("Valor de depósito inválido.");
                }
            }

            public void Sacar(double valor)
            {
                if (valor > 0 && this.saldo >= valor)
                {
                    this.saldo -= valor;
                    System.Console.WriteLine("Saque realizado com sucesso!");
                }
                else
                {
                    System.Console.WriteLine("Valor de saque inválido ou saldo insuficiente.");
                }
            }

            public void ExibirInformacao()
            {
                System.Console.WriteLine("Seu saldo atual é ..: {0} ", this.saldo);
                System.Console.WriteLine("Seu limite atual é ..: {0}", this.limite);
            }
        }

        static void Main(string[] args)
        {
            ContaBancaria c1 = new ContaBancaria(0, 1000);
            ContaBancaria c2 = new ContaBancaria(500, 1000);

            System.Console.WriteLine("Digite o valor a ser depositado na conta 1:");
            double valorDeposito = double.Parse(Console.ReadLine());
            c1.Depositar(valorDeposito);

            System.Console.WriteLine("Digite o valor a ser sacado da conta 1:");
            double valorSaque = double.Parse(Console.ReadLine());
            c1.Sacar(valorSaque);

            c1.ExibirInformacao();
            c2.ExibirInformacao();
        }
    }
}
