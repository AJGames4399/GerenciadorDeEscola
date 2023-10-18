using System;
using System.Collections.Generic;

namespace Gerenciador_De_Escola
{

    public class Curso
    {
        public int CodigoCurso { get; set; }
        public string Nome { get; set; }
        public List<Aluno> Alunos { get; set; }
        public List<Disciplina> Disciplinas { get; set; }

        public Curso(int codigo, string nome)
        {
            CodigoCurso = codigo;
            Nome = nome;
            Alunos = new List<Aluno>();
            Disciplinas = new List<Disciplina>();
        }

        public void AdicionarAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
        }

        public void AdicionarDisciplina(Disciplina disciplina)
        {
            Disciplinas.Add(disciplina);
        }

        public string ListarAlunos()
        {
            string sMensagem = "Lista de Alunos:\n";
            foreach (var aluno in Alunos)
            {
                sMensagem += aluno.ExibirDados() + "\n";
            }
            return sMensagem;
        }

        public string ListarDisciplinas()
        {
            string sMensagem = "Lista de Disciplinas:";
            foreach (var disciplina in Disciplinas)
            {
                sMensagem += "\n   Titulo: " + disciplina.Nome;
                sMensagem += "\n   Carga Horaria: " + disciplina.CargaHoraria;
                sMensagem += "\n   Ementa: " + disciplina.Ementa+"\n";
            }
            return sMensagem;
        }

        public string ExibirDados()
        {
            return CodigoCurso + ": "+Nome+", "+ListarDisciplinas();
        }
    }
}
