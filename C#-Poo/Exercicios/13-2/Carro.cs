using System;

class Carro : Veiculo
{
    public override void CalularImpostoAnual(double valor)
    {
        System.Console.WriteLine($"o imposto anual do Carro é {valor * 0.10}");
    }

    public override void CalularConsumoCombustivel(double litros, double kms)
    {
        System.Console.WriteLine(
            $"o Consumo de do Carro {litros} litros em  {kms}Km é :  {litros / kms} Por Km"
        );
    }
}
