﻿using System;
using System.Collections.Generic;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            Console.WriteLine($"Digite 10 números");
            for (int i = 1; i <= 10; i++)
           {
                Console.WriteLine($"Número {i}:");
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
            Console.WriteLine($"O maior número é: {maiorNumero}");

            //remove o menor numero da lista
            numeros.Remove(menorNumero);

            Console.WriteLine("A lista resultante foi:");
            foreach (int numero in numeros)
           {
                Console.WriteLine(numero);
            }
        }
    }
}
