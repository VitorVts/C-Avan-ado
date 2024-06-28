using System;
using System.Collections.Generic;

namespace _24_MediaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 5 };

            double media = Media(numeros);
            Console.WriteLine(media);
        }

        static double Media(List<int> numeros)
        {
            if (numeros.Count == 0)
            {
                return 0;
            }

            int soma = 0;
            foreach (int numero in numeros)
            {
                soma += numero;
            }

            double media = (double)soma / numeros.Count;
            return media;
        }
    }
}
