using System;
using System.Collections.Generic;

namespace Gerenciador_De_Escola
{

    public class Aluno : Pessoa
    {
        public int MatriculaAluno { get; private set; }

        public DateTime DataMatricula { get; private set; }

        public Aluno(string nome, DateTime dataNascimento) : base(nome, dataNascimento)
        {
            MatriculaAluno = new Random().Next(1, 999);
            DataMatricula = DateTime.Today;
        }

        //public Aluno(string nome, int idade, int matricula) : base(nome, idade)
        //{
        //    Matricula = matricula;
        //    Cursos = new List<Curso>();
        //    DataMatricula = DateTime.Now;
        //}

        public void Matricular(Curso curso)
        {
            if (!Cursos.Contains(curso))
            {
                Cursos.Add(curso);
            }
        }



        public override string ExibirDados()
        {
            string[] sDados = base.ExibirDados().Split(' ');
            return MatriculaAluno + ": " + sDados[0] + ", Data De Nascimento: " + sDados[1] + "(" + sDados[2] + " Anos), Matriculado na escola dia: " + DataMatricula;
        }

    }
}

