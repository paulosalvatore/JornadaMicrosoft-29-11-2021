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
            // Número - inteiro - Int, Long - Principal: Int
            // Número - decimal - Float, Double, Decimal - Principal: Double


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

            /*
            Console.WriteLine("Digite o seu nome:");

            string nome = Console.ReadLine();

            Console.WriteLine($"Olá, {nome}!");
            */

            // Exemplo 5
            
            // Número - inteiro - Int, Long - Principal: Int
            // Número - decimal - Float, Double, Decimal - Principal: Double

            /*
            var nome = "Paulo";
            var idade = 10;
            var altura = 1.8;

            Console.WriteLine($"Olá, {nome}, você possui {idade} anos de idade e mede {altura}cm.");
            */

            // Operações matemáticas
            /*
            var soma = 10 + 5;
            var subtracao = 10 - 5;
            var multiplicacao = 10 * 2;
            var divisao = 10.0 / 3;

            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Subtração: {subtracao}");
            Console.WriteLine($"Multiplicação: {multiplicacao}");
            Console.WriteLine($"Divisão: {divisao}");
            */

            // Desafio 1
            // Calculadora dos 10% do Garçom
            // Declarar uma variável com o valor da conta
            // Declarar uma variável com o valor da taxa adicional do Garçom
            // Declarar uma variável com o resultado dessa operação, adicionando a porcentagem da taxa no valor da conta
            // Essa terceira variável deve utilizar o valor das duas primeiras para fazer o cálculo
            // Ao final, exiba quanto ficou o valor total da conta

            /*
            10              por cento
            10              /   100
            porcentagemTaxa /   100
            */

            /*
            var valorConta = 45.35;
            var porcentagemTaxa = 10;

            var valorTaxa = valorConta * porcentagemTaxa / 100;

            var valorTotal = valorConta + valorTaxa;

            // Resultado de 45.35 + 10% deve dar: 49.885

            Console.WriteLine($"Valor da conta foi de R{valorConta:C}."); // Currency
            Console.WriteLine($"A taxa do garçom foi de R{valorTaxa:C}.");
            Console.WriteLine($"A conta ficou no total de R{valorTotal:C}.");
            */

            // Exemplo 6

            /*
            Console.WriteLine("Escreva um número de 0 a 10:");

            var numeroDigitado = Console.ReadLine();

            var numero = int.Parse(numeroDigitado);

            Console.WriteLine($"Você digitou o número {numero}.");
            Console.WriteLine($"{numero} + {10} = {numero + 10}");
            */

            // Exemplo 7
            
            Console.WriteLine("Quanto foi a conta:");

            var valorContaString = Console.ReadLine();

            var valorConta = double.Parse(valorContaString);

            var porcentagemTaxa = 10;

            var valorTaxa = valorConta * porcentagemTaxa / 100;

            var valorTotal = valorConta + valorTaxa;

            // Resultado de 45.35 + 10% deve dar: 49.885

            Console.WriteLine($"Valor da conta foi de R{valorConta:C}."); // Currency
            Console.WriteLine($"A taxa do garçom foi de R{valorTaxa:C}.");
            Console.WriteLine($"A conta ficou no total de R{valorTotal:C}.");
        }
    }
}
