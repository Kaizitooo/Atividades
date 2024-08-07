using Atividades;
using System;

public class Program
{
    public static void Main(string[] args)
    {

        Console.Write("Qual o nome desse cabeça aí? ");
        string nome = Console.ReadLine();

        Console.Write("Quantos anos você tem? ");
        int idade;
        while (!int.TryParse(Console.ReadLine(), out idade))
        {
            Console.Write("Por favor, insira uma idade válida: ");
        }

        Console.Write("Qual é o seu peso (em kg)? ");
        double peso;
        while (!double.TryParse(Console.ReadLine(), out peso))
        {
            Console.Write("Por favor, insira um peso válido: ");
        }

        Console.Write("Qual é a sua altura (em metros)? ");
        double altura;
        while (!double.TryParse(Console.ReadLine(), out altura))
        {
            Console.Write("Por favor, insira uma altura válida: ");
        }

        Pessoa pessoa = new Pessoa(nome, idade, peso, altura);

        Console.WriteLine($"\nEntão as informações são:");
        Console.WriteLine($"Nome: {pessoa.nome}");
        Console.WriteLine($"Idade: {pessoa.idade}");
        Console.WriteLine($"Peso: {pessoa.peso} kg");
        Console.WriteLine($"Altura: {pessoa.altura} m");

        Console.WriteLine("\nEntão, com o passar dos anos...");

        pessoa.envelhecer();

        Console.WriteLine($"\nDepois de envelhecer, as informações são:");
        Console.WriteLine($"Nome: {pessoa.nome}");
        Console.WriteLine($"Idade: {pessoa.idade}");
        Console.WriteLine($"Peso: {pessoa.peso} kg");
        Console.WriteLine($"Altura: {pessoa.altura} m");
    }
}
