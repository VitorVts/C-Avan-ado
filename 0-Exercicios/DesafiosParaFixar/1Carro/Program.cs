namespace _1Carro;

class Program
{
    static void Main(string[] args)
    {
        Carro c = new Carro("Chevrolet", "Monza", 1988, 0);

        c.Acelerar();
        c.Frear();
        c.ShowInformation();
    }
}
