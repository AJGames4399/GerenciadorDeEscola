using System;
using System.Collections.Generic;

namespace Gerenciador_De_Escola
{

    public class Professor : Pessoa
    {

        public int matriculaProfessor {  get; private set; }
        public List<Disciplina> Disciplinas { get; private set; }



        public Professor(string nome, DateTime dataNascimento) : base(nome, dataNascimento)
        {
            matriculaProfessor = new Random().Next(1, 999);
            Disciplinas = new List<Disciplina>();
        }

        // Essa classe também não é muito utilizada, talvez seja interessante colocar alguns recursos aqui que estão em gerenciar escola.
        //Antigo AdicionarDisciplina, alterar no UML

        public void AlocarDisciplina(Disciplina disciplina, Curso curso) 
        {
            if(!curso.Disciplinas.Contains(disciplina))
            {
                if (!Disciplinas.Contains(disciplina))
                {
                    Disciplinas.Add(disciplina);
                }
            }
        }

        public string ListarDisciplinas()
        {
            string sMensagem = "Disciplinas Lecionadas:\n";
            foreach(var disciplina in Disciplinas)
            {
                sMensagem += disciplina.Titulo + " (";
                foreach(var curso in Cursos)
                {
                    if (curso.Disciplinas.Contains(disciplina))
                    {
                        sMensagem += curso.Nome + " ,";
                    }
                    sMensagem.TrimEnd(' ', ',');
                    sMensagem += ")\n";
                }
            }
            
            
            return sMensagem; 
        }

        public override string ExibirDados()
        {
            string[] sDados = base.ExibirDados().Split(' ');
            return matriculaProfessor + ": " + sDados[0] + ", Data De Nascimento: " + sDados[1] + "(" + sDados[2] + " Anos)\n"+ListarDisciplinas();
            //Console.WriteLine($"Disciplinas: {string.Join(", ", Diciplinas)}");
        }

    }
}
