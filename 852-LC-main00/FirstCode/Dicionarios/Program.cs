using System;

namespace Dicionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool usuarioLogado = false;
            int tentativas = 1;
            //while (condicao)
            //while (usuarioBloqueado==false)

            string usuario = "a";
            string senha = "a";
            // while (us)

            // int qtdTentativasMaxima = 3;
            while (!usuarioLogado)
            {
                Console.WriteLine("Digite um usuário:");
                string inputUsuario = Console.ReadLine();
                Console.WriteLine("Digite uma senha:");
                string inputSenha = Console.ReadLine();
                /* foreach (int key in usuarios.Keys)
                 {
                     usuarioValido = true;
                     break;
                 }

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
             }*/
            }
        }
    }
}