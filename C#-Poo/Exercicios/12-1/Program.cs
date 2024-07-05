namespace _12;

class Program
{
    static void Main(string[] args)
    {
        Veiculo s = new Veiculo("Chevrolet", "Monza", 1983);
        Carro c = new Carro("Chevrolet", "Onix", 2022, 4);
        Moto m = new Moto("Honda", "Hornet", 2024, 1000);
        s.ExibirInformacoes();
        c.ExibirInformacoesCarro();
        m.ExibirInformacoesMoto();
    }
}
