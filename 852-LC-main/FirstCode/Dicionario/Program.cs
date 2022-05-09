using System;
using System.Collections.Generic;

namespace Dicionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //usuario,senha
            Dictionary<string, string> usuarios = new Dictionary<string, string>();
            usuarios.Add("123", "a");
            usuarios.Add("456", "b");
            usuarios.Add("789", "c");

            List<string> usuariosBloqueados = new List<string>();
            usuariosBloqueados.Add("123");
            bool usuarioLogado = false;

            //usuario,tentativa
            Dictionary<string, int> usuariosTentativas = new Dictionary<string, int>();

            while (!usuarioLogado)
            {
                Console.WriteLine("Digite um usuário:");
                string inputUsuario = Console.ReadLine();
                Console.WriteLine("Digite uma senha:");
                string inputSenha = Console.ReadLine();

                //Verifica se o usuário está bloqueado e
                //vai para a proxima iteracao caso esteja
                if (usuariosBloqueados.Contains(inputUsuario))
                {
                    Console.WriteLine("Usuário Bloqueado");
                    continue;
                }
                //percorre os usuarios cadastrados (através da chave)
                foreach (string id in usuarios.Keys)
                {
                    //se o usuario digitado for igual ao usuario da chave
                    if (inputUsuario == id)
                    {
                        //valida se a senha está certa, se estiver
                        //interrompe o laço
                        if (inputSenha == usuarios[id])
                        {
                            usuarioLogado = true;
                            Console.WriteLine("Logado com sucesso");
                            break;
                        }
                        //caso a usuario esteja errada
                        else
                        {
                            //verifica se já houve alguma tentativa para aquele
                            //usuario
                            if (usuariosTentativas.ContainsKey(inputUsuario))
                            {
                                //se ja houve tentativa, acrescenta + 1 ao contador
                                usuariosTentativas[inputUsuario] += 1;
                            }
                            else
                            {
                                //se ainda n'ao houve tentativa, adiciona
                                //no dicionario com valor 1 (1ª tentativa)
                                usuariosTentativas.Add(inputUsuario, 1);
                            }
                            //valida se excedeu o numero de tentativas
                            if (usuariosTentativas[inputUsuario] > 3)
                            {

                                Console.WriteLine($"Número de tentativas máximas excedidas para o usuário {inputUsuario}");
                                //se excedeu bloqueia o usuario (adicionando na lista de usu[arios bloqueados)
                                usuariosBloqueados.Add(inputUsuario);
                                continue;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Falha de autenticação. Usuário ou senha inválidos");
        }
    }
}
