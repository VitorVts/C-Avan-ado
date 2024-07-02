using System;

namespace _29_Construtores_e_Destrutores
{
    public class Jogador
    {
        public int energia;
        public bool vivo;
        public string nome;

        public Jogador(string n)
        {
            nome = n;
            energia = 100;
            vivo = true;
        }

        ~Jogador()
        {
            Console.WriteLine($"Jogador {nome} foi destruído");
        }

        public void ReduzirEnergia(int quantidade)
        {
            energia -= quantidade;
            if (energia <= 0)
            {
                energia = 0;
                vivo = false;
                System.Console.WriteLine("Jogador foi de saudades");
            }
        }

        public void ExibirEstado()
        {
            Console.WriteLine($"Nome: {nome}, Energia: {energia}, Vivo: {vivo}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Jogador jogador = new Jogador("Jogador1");

            Console.WriteLine("Estado inicial do jogador:");
            jogador.ExibirEstado();

            Console.WriteLine("Estado FInal do jogador pós jogo:");
            jogador.ReduzirEnergia(110);
            jogador.ExibirEstado();
        }
    }
}
