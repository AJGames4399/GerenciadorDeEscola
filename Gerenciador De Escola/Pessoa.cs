using System;
using System.Collections.Generic;

namespace Gerenciador_De_Escola
{

    public class Pessoa
    {
        public string Nome { get; set; }
       // public DateTime DataNascimento { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public virtual void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome} - Idade: {Idade}");
        }

    }
}

