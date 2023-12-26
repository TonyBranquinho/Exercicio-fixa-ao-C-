using System;
using System.Globalization;

namespace MyApp // Exercicio fixaçao C#.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture; 

            //String nome;
            //float quartos;
            //float preco;
            //float[] vet = Console.ReadLine().Split(' ');
            //float a = vet[0];
            //float b = vet[1];
            //float c = vet[2];

            Console.WriteLine("Entre com seu nome completo: ");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preco de um produto:");
            double preco = double.Parse(Console.ReadLine(), CI);
            Console.WriteLine("Entre seu ultimo nome, idade e altura (mesma linha)");
            
            string[] vet = Console.ReadLine().Split(' ');
            string ultimoNome = vet[0]; 
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);


            Console.WriteLine(nomeCompleto);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CI));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);  
            
        }
    }
}