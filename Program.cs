using System;

namespace dotnetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Comentário
            // Console.WriteLine -> escreve algo na tela
            // Console.WriteLine("Hello World!");

            /*
            Comentário
            com
            várias
            linhas
            */

            // Variáveis -> Guardam informações na memória RAM
            // 1ª - Tipo da informação (em alguns casos, podemos substituir por 'var')
            // 2ª - O que aquela informação representa
            // 3ª - A informação em si
            // Toda instrução no C# é finalizada com ponto e vírgula (;)

            // Tipos de informações
            // Texto - String - Fica dentro de aspas duplas


            // Exemplo 1

            // Declaramos a variável 'nome', com o valor "Paulo Salvatore", na memória RAM
            // string nome = "Paulo Salvatore";

            // Console.WriteLine(nome);


            // Exemplo 2

            /*
            // Declaramos a variável 'nome', com o valor "Paulo Salvatore", na memória RAM
            string nome = "Paulo";
            string sobrenome = "Salvatore";

            // Concatenar = unir duas informações de maneira lógica
            string nomeCompleto = nome + " " + sobrenome;

            Console.WriteLine(nomeCompleto);
            
            Console.WriteLine(nome + " " + sobrenome);
            */

            // Exemplo 3
            // Formatação de strings

            /*
            string nome = "Paulo";
            string sobrenome = "Salvatore";

            string nomeCompleto = $"Olá, {nome} {sobrenome}!";

            Console.WriteLine(nomeCompleto);
            */

            // Exemplo 4

            Console.WriteLine("Digite o seu nome:");

            string nome = Console.ReadLine();

            Console.WriteLine($"Olá, {nome}!");
        }
    }
}
