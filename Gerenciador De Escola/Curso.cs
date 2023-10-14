using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_De_Escola
{
    internal class Curso
    {
        public int CodigoCurso { get; set; }
        public string Nome { get; set; }
        public List<Aluno> Alunos { get; set; }
        public List<Disciplina> Disciplinas { get; set;}

        public Curso()
        {
            
        }

        public void AdicionarAluno(Aluno aluno)
        {
            
        }

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
    }
}
