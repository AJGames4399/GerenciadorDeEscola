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

        public Curso(string nome)
        {
            CodigoCurso = new Random().Next(1,999);
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
        Respostas: Classes foram retiradas do GerenciadorEscoal e colocadas aqui

        */

        public void AdicionarDisciplina(Disciplina disciplina)
        {
            if (!Disciplinas.Contains(disciplina))
            {
                Disciplinas.Add(disciplina);
            }
            else
            {
                Console.WriteLine("Disciplina já alocada para este curso");
            }

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
                sMensagem += "\nTitulo: " + disciplina.Titulo;
                sMensagem += "\nCarga Horaria: " + disciplina.CargaHoraria;
                sMensagem += "\nEmenta: " + disciplina.Ementa;
            }
            return sMensagem;
        }




    }
}
