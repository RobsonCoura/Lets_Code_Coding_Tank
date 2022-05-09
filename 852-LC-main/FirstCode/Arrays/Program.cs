using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            int[] numeros = new int[10];
            Console.WriteLine("Digite 10 números");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Número {i + 1}:");
                string numaux = Console.ReadLine();
                int numero;
                int.TryParse(numaux, out numero);
                numeros[i] = numero;
            }
            int maiorNumero = numeros[0];
            int menorNumero = 0;
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
            //devido a array ter tamanho fixo, para remover elementos 
            //precisamos criar um novo array com menos elementos
            int[] novoArray = new int[numeros.Length - 1];
            int indice = 0;
            bool removido = false;
            foreach (int numero in numeros)
            {
            //verifica se ainda não removeu o número,
            //    se não removeu ele remove e continua a iteração
               if (menorNumero == numero && !removido)
                {
                    removido = true;
                    continue;
                }
                novoArray[indice] = numero;
                indice++;
            }
            Console.WriteLine($"O maior número é: {maiorNumero}");
            Console.WriteLine($"O array resultante foi:");
            foreach (int numero in novoArray)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
