using System;

namespace Colecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region "Arrays"
            //int tamanho = 2;
            int[] numeros = new int[10];
            Console.WriteLine("Digite 10 numeros:");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Número {i + 1}: ");
                string numaux = Console.ReadLine();
                int numero;
                int.TryParse(numaux, out numero);
                numeros[i] = numero;
            }
            int maiorNumero = numeros[0];
            int menorNumero = numeros[0];
            foreach (int i in numeros)
            {
                if(maiorNumero < i)
                {
                    maiorNumero = i;
                }
                if(menorNumero > i)
                {
                    menorNumero = i;
                }
            }
            int[] novoArray = new int[numeros.Length - 1];
            int indice = 0;
            bool removido = false;
            foreach(int numero in numeros)
            {
                if(menorNumero == numero && !removido)
                {
                    removido = true;
                    continue;
                }
                novoArray[indice] = numero;
                indice++;
            }
            Console.WriteLine($"O maior numero foi: {maiorNumero}");
            Console.WriteLine($"O array resultante foi: {menorNumero}");
            foreach (int numero in novoArray)
            {
                Console.WriteLine(numero);
            }
        }
        #endregion
    }
}
