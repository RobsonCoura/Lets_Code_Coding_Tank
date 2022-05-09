using System;
using System.Collections.Generic;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int tamanho = 2;
            List<int> numeros = new List<int>();
            Console.WriteLine("Digite 10 numeros:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Número {i}: ");
                string numaux = Console.ReadLine();
                int numero;
                int.TryParse(numaux, out numero);
                numeros.Add(numero);
            }
            int maiorNumero = numeros[0];
            int menorNumero = numeros[0];
            foreach (int i in numeros)
            {
                if (maiorNumero < i)
                {
                    maiorNumero = i;
                }
                if (menorNumero > i)
                {
                    menorNumero = i;
                }
            }
            Console.WriteLine($"O maior numero foi: {maiorNumero}");

            numeros.Remove(menorNumero);

            Console.WriteLine("O array resultante foi:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }

    }
}
