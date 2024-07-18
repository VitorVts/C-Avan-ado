namespace Banco;

public class Program
{
    static void Main(string[] args)
    {
        ContaBancaria c1 = new ContaBancaria("123456", "Vitor", 1500);

        c1.Depositar(1500);
        c1.Sacar(300);
        c1.ExibirSaldo();
    }
}
