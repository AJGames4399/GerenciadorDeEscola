using System;
using System.Collections.Generic;

namespace Gerenciador_De_Escola
{

    public class Aluno : Pessoa
    {
        public int MatriculaAluno { get; private set; }

        public Aluno(int matricula, string nome, DateTime dataNascimento) : base(nome, dataNascimento)
        {
            MatriculaAluno = matricula;
        }

        public void Matricular(Curso curso)
        {
            Cursos.Add(curso);
        }

        public override string ExibirDados()
        {
            return MatriculaAluno + ": " + base.ExibirDados();
        }

    }
}

