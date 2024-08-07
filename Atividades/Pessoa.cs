using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades
{
    public class Pessoa
    {
        public string nome;
        public int idade;
        public double peso;
        public double altura;

        public Pessoa(string nome, int idade, double peso, double altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.peso = peso;
            this.altura = altura;
        }

        public void envelhecer()
        {
            while (idade < 120)
            {
                idade++;
                if (idade < 21)
                {
                    altura += 0.5;
                }
            }

            if (idade == 120)
            {
                Console.WriteLine("Essa pessoa aí morreu");
            }
            if (idade > 120)
            {
                Console.WriteLine("Esse caba aí é um vampiro");
            }
        }
        public void engordar()
        {
        }
        public void emagrecer()
        {
        }
        public void crescer()
        {
        }
    }
}
