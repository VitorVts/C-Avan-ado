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
    }

    class Program
    {
        static void Main(string[] args)
        {
            CriarEExcluirJogador();

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        static void CriarEExcluirJogador()
        {
            if (true)
            {
                Jogador jogador = new Jogador("Joador 1 ");
                Console.WriteLine($"Jogador {jogador.nome} foi criado.");
            }
        }
    }
}
