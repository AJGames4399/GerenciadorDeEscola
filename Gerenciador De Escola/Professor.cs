using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_De_Escola
{
    internal class Professor : Pessoa
    {
        public int Matricula { get; set; }
        public List<Disciplina> Disciplinas { get; set;}

        public Professor()
        {

        }

        public void AdicionarDisciplina(Disciplina disciplina) {
        
        }

        public List<Disciplina> ListarDisciplinas()
        {
            return Disciplinas;
        }
    }
}
