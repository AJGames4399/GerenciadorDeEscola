using System;
using System.Collections.Generic;

namespace Gerenciador_De_Escola
{

    public class Curso
    {
        public string Nome { get; set; }
        // public int CargaHoraria { get; set; }

        public int CodigoCurso { get; set; }
        public List<Aluno> Alunos { get; set; }
        public List<Disciplina> Disciplinas { get; set; }

        public Curso(string nome, int codigoCurso)
        {
            Nome = nome;

            Alunos = new List<Aluno>();
            Disciplinas = new List<Disciplina>();
        }

        public void AdicionarAluno(Aluno aluno)
        {
            if (!Alunos.Contains(aluno))
            {
                Alunos.Add(aluno);
            }
            else
            {
                Console.WriteLine("Aluno já matriculado neste curso");
            }
        }

        /*

        Essa classe não foi muito utilizada em alguns recursos que estão na classe gerenciar escola, talvez possam ser incorporados aqui.

        public void AdicionarDisciplina(Disciplina disciplina)
        {

        }

        public List<Aluno> ListarAlunos()
        {
            return Alunos;
        }

        public List<Disciplina> ListarDisciplinas()
        {
            return Disciplinas;
        }

*/




    }
}
