using System;

class Caminhao : Veiculo
{
    public override void CalularImpostoAnual(double valor)
    {
        System.Console.WriteLine($"o imposto anual do Caminhao é {valor * 0.20}");
    }

    public override void CalularConsumoCombustivel(double litros, double kms)
    {
        System.Console.WriteLine(
            $"o Consumo de do Caminhao {litros} litros em  {kms}Km é :  {litros / kms} Por Km"
        );
    }
}
