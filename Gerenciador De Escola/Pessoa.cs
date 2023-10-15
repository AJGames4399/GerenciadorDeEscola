using System;
using System.Collections.Generic;

namespace Gerenciador_De_Escola
{

    public class Pessoa
    {
        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public int Idade { get; private set; }
        public List<Curso> Cursos { get; private set; }


        public Pessoa(string nome, DateTime dataNascimento)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Idade = DateTime.Today.Year - dataNascimento.Year;
            Cursos = new List<Curso>();

        }

        public virtual string ExibirDados()
        {
            string sMensagem = Nome + " ";
            sMensagem += DataNascimento + " ";
            sMensagem += Idade;
            return sMensagem;
        }

    }
}

