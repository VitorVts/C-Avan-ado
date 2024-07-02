namespace _32_Construtor_Sobrecarga
{
    class Program
    {
        class Retangulo
        {
            public int largura;
            public int altura;

            public Retangulo(int largura, int altura)
            {
                this.largura = largura;
                this.altura = altura;
            }

            public Retangulo(int valor)
                : this(valor, valor) { }

            public void ExibirInformacao()
            {
                System.Console.WriteLine("Largura: {0}, Altura: {1}", largura, altura);
            }
        }

        static void Main(string[] args)
        {
            Retangulo r1 = new Retangulo(100, 100);
            Retangulo r2 = new Retangulo(100);

            r1.ExibirInformacao();
            r2.ExibirInformacao();
        }
    }
}
