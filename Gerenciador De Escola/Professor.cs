using System;
using System.Collections.Generic;

namespace Gerenciador_De_Escola
{

    public class Professor : Pessoa
    {

        public int matriculaProfessor {  get; private set; }
        public List<Disciplina> Disciplinas { get; private set; }



        public Professor(int Matricula, string nome, DateTime dataNascimento) : base(nome, dataNascimento)
        {
            matriculaProfessor = Matricula;
            Disciplinas = new List<Disciplina>();
        }

        public void AlocarDisciplina(Disciplina disciplina)
        {
            Disciplinas.Add(disciplina);
        }

        public string ListarDisciplinas()
        {
            string sMensagem = "Disciplinas Lecionadas:\n";
            foreach(var disciplina in Disciplinas)
            {
                sMensagem += disciplina.Nome + " (";
                foreach(var curso in Cursos)
                {
                    if (curso.Disciplinas.Contains(disciplina))
                    {
                        sMensagem += curso.Nome + ", ";
                    }
                }
                sMensagem.TrimEnd(',', ' ');
                sMensagem += ")\n";
            }
            
            
            return sMensagem; 
        }

        public override string ExibirDados()
        {
            return matriculaProfessor + ": " + base.ExibirDados()+ListarDisciplinas();
        }

    }
}
