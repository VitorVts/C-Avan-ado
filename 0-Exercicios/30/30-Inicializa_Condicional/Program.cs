namespace _30_Inicializa_Condicional;

class Program
{
    public class Carro
    {
        public string marca;
        public string modelo;
        public int anoFabricado;

        public Carro(string m, string mdl)
        {
            marca = m;
            modelo = mdl;
            anoFabricado = DateTime.Now.Year;
        }

        public Carro(string m, string mdl, int a)
        {
            marca = m;
            modelo = mdl;
            anoFabricado = a;
        }

        public void ExibirInformacao()
        {
            System.Console.WriteLine("Carros na Concessionária:");
            System.Console.WriteLine("Marca..: {0}", marca);
            System.Console.WriteLine("Modelo..: {0}", modelo);
            System.Console.WriteLine("Ano de Fabricação..:{0}\n", anoFabricado);
        }
    }

    static void Main(string[] args)
    {
        Carro c1 = new Carro("Chevy", "Corvette");
        Carro c2 = new Carro("Audi", "A4", 2011);

        c1.ExibirInformacao();
        c2.ExibirInformacao();
    }
}
