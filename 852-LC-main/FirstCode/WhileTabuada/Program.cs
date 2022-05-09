using System;

namespace WhileTabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroCalculado = 0;
            int atualTabuada = 0;
            int maximoTabuada = 10;
            bool numeroValido = false;
            //string xpto = null;

            while (!numeroValido)
            {
                Console.WriteLine("Entra um número para calcular a tabuada até 10.");
                numeroValido = (int.TryParse(Console.ReadLine(), out numeroCalculado)
                               && numeroCalculado > 0);
                if (numeroValido)
                {
                    break;
                }
                Console.WriteLine("Número inválido");
            }
            do
            {
                Console.WriteLine($"{numeroCalculado}*{atualTabuada} = {numeroCalculado * atualTabuada}");
                atualTabuada++;
            }
            while (atualTabuada <= maximoTabuada);
        }
    }
}
    

