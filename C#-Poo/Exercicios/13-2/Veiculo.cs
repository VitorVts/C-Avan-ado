using System;

class Veiculo
{
    public virtual void CalularImpostoAnual(double valor)
    {
        System.Console.WriteLine($"o imposto anual do veiculo é {valor * 0.05}");
    }

    public virtual void CalularConsumoCombustivel(double litros, double kms)
    {
        System.Console.WriteLine(
            $"o Consumo de {litros} litros em  {kms}Km é :  {litros / kms}L Por Km"
        );
    }
}
