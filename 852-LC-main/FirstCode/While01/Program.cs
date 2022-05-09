using System;

namespace While01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool usuarioBloqueado = false;
            int tentativas = 1;
            string usuario = "a";
            string senha = "a";
            int qtdTentativasMaxima = 3;
            bool usuarioValido = false;

            //while (condicao)
            while (usuarioBloqueado == false)
                while (!usuarioBloqueado)
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
                            Console.WriteLine($"Usuário ou senha inválido. Tente novamente.({qtdTentativasMaxima - tentativas} tentativas restantes)");
                        }

                        if (tentativas == qtdTentativasMaxima)
                        {
                            usuarioBloqueado = true;
                            Console.WriteLine($"Usuário bloqueado, senta e chora.");
                            return;
                        }
                    }
                    tentativas++;
                }
            if (usuarioValido)
            {
                Console.WriteLine("Usuário logado com sucesso");
            }
        }
    }
}
