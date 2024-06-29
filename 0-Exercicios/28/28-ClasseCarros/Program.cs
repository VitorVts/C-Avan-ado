namespace _28_ClasseCarros
{
    public class Carros
    {
        public string marca = "";
        public string modelo = "";
        public int ano = 0;
        public double velocidadeAtual = 0;
        public bool ligado = false;

        public void Acelerar()
        {
            velocidadeAtual++;
            Console.Clear();
            System.Console.WriteLine("Velocidade Atual: {0} Km/h", velocidadeAtual);
        }

        public void Freiar()
        {
            Console.Clear();
            if (velocidadeAtual > 0)
            {
                velocidadeAtual--;
            }
            else
            {
                System.Console.WriteLine("Carro Parado. Aperte ESC para desligar.");
            }

            System.Console.WriteLine("Velocidade Atual: {0} Km/h", velocidadeAtual);
        }

        public void Ligar()
        {
            ligado = true;
            System.Console.WriteLine("Carro Ligado");
            System.Console.WriteLine(
                "Aperte a seta para cima para acelerar ou para baixo para frear. Aperte ESC para desligar."
            );

            do
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    Acelerar();
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    Freiar();
                }
                else if (keyInfo.Key == ConsoleKey.Escape)
                {
                    ligado = false;
                    System.Console.WriteLine("Carro Desligado");
                }
            } while (ligado);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Carros pug = new Carros();

            pug.modelo = "207";
            pug.ano = 2011;
            pug.marca = "Peugeot";
            pug.velocidadeAtual = 0;
            pug.ligado = false;

            System.Console.WriteLine("Especificações do carro: ");
            System.Console.WriteLine("Marca: {0}", pug.marca);
            System.Console.WriteLine("Modelo: {0}", pug.modelo);
            System.Console.WriteLine("Ano de Fabricação: {0}", pug.ano);
            System.Console.WriteLine("\nLigar o carro? (S para ligar, N para sair)");
            string option = Console.ReadLine();
            if (option.ToUpper() == "S")
            {
                pug.Ligar();
            }
        }
    }
}
