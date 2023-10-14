using System;
using System.Collections.Generic;

namespace SchoolManagement
{

    public class Professor : Pessoa
    {

        public List<Disciplina> Diciplinas { get; set; }


        public Professor(string nome, int idade) : base(nome, idade)
        {
            Diciplinas = new List<Disciplina>();
        }

        // Essa classe também não é muito utilizada, talvez seja interessante colocar alguns recursos aqui que estão em gerenciar escola.

        public void AlocarDisciplina(Disciplina disciplina)
        {
            if (!Diciplinas.Contains(disciplina))
            {
                Diciplinas.Add(disciplina);
            }
            else
            {
                Console.WriteLine("Disciplina já alocada para este professor");
            }
        }

        public override void ExibirDados()
        {
            base.ExibirDados();
            //Console.WriteLine($"Disciplinas: {string.Join(", ", Diciplinas)}");
        }

    }
}
