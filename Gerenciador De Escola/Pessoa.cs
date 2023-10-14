using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_De_Escola
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get; set; }
        public List<Curso> Curso { get; set; }

        public Pessoa()
        {

        }

        public void AdicionarCurso(Curso curso)
        {

        }

        public List<Curso> ListarCursos()
        {
            return Curso;
        }
    }
}
