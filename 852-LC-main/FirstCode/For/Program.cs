using System;

namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (valor inicial do elemento; condicional de encerrar o laço, incremento)
            //mesmo resultado, com formas diferentes
            //i++
            //i = i + 1;
            //i += 1;
            string usuario = "a";
            string senha = "a";
            int qtdTentativasMaxima = 3;
            bool usuarioValido = false;

            for (int tentativas = 1; tentativas <= qtdTentativasMaxima; tentativas++)
            {
                Console.WriteLine("Digite um usuário:");
                string inputUsuario = Console.ReadLine();
                Console.WriteLine("Digite uma senha:");
                string inputSenha = Console.ReadLine();

                if (usuario == inputUsuario && senha == inputSenha)
                {
                    usuarioValido = true;
                    break;
                }
                else
                {
                    if (tentativas < qtdTentativasMaxima)
                    {
                        Console.WriteLine("Usuário ou senha inválido. Tente novamente.");
                    }
                }
                if (usuarioValido)
                {
                    Console.WriteLine("Usuário logado com sucesso");
                }
            }
        }
    }
}

