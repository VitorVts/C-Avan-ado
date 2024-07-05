namespace _13_2;

class Program
{
    static void Main(string[] args)
    {
        Veiculo v = new Veiculo();
        Veiculo C = new Carro();
        Veiculo M = new Moto();
        Veiculo Cm = new Caminhao();

        Console.Clear();
        C.CalularImpostoAnual(50000);
        C.CalularConsumoCombustivel(250, 50);
        System.Console.WriteLine("-----------------------------------------------------");
        v.CalularImpostoAnual(20000);
        v.CalularConsumoCombustivel(300, 50);
        System.Console.WriteLine("-----------------------------------------------------");
        M.CalularImpostoAnual(20000);
        M.CalularConsumoCombustivel(1000, 50);
        System.Console.WriteLine("-----------------------------------------------------");
        Cm.CalularImpostoAnual(100000);
        Cm.CalularConsumoCombustivel(1000, 10000);
    }
}
