using System;

class Moto : Veiculo
{
    public override void CalularImpostoAnual(double valor)
    {
        System.Console.WriteLine($"o imposto anual do Moto é {valor * 0.01}");
    }

    public override void CalularConsumoCombustivel(double litros, double kms)
    {
        System.Console.WriteLine(
            $"o Consumo de do Moto {litros} litros em  {kms}Km é :  {litros / kms} Por Km"
        );
    }
}
