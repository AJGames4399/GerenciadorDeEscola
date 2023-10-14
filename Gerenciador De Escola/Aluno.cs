using System;
using System.Collections.Generic;

namespace Gerenciador_De_Escola
{

    public class Aluno : Pessoa
    {
        public int Matricula { get; set; }
        public List<Curso> Cursos { get; private set; }

        private DateTime DataMatricula { get; set; }

        public Aluno(string nome, int idade, int matricula) : base(nome, idade)
        {
            Matricula = matricula;
            Cursos = new List<Curso>();
            DataMatricula = DateTime.Now;
        }

        public void Matricular(Curso curso)
        {
            if (!Cursos.Contains(curso))
            {
                Cursos.Add(curso);
                DataMatricula = DateTime.Now;
            }
            else
            {
                Console.WriteLine("Aluno já matriculado neste curso");
            }

        }



        public override void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Matricula: {Matricula} - Data Matricula: {DataMatricula}");
        }

    }
}

