using System;
using System.Collections.Generic;

namespace Gerenciador_De_Escola
{
    public class Disciplina
    {
        public int CodigoDisciplina { get; set;}
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public string Ementa { get; set; }

        public Disciplina(int codigo, string titulo, int cargaHoraria, string ementa)
        {
            CodigoDisciplina = CodigoDisciplina;
            Nome = titulo;
            CargaHoraria = cargaHoraria;
            Ementa = ementa;
        }

        public string ExibirDados()
        {
            return CodigoDisciplina+": "+ Nome + ", Carga Horaria: "+ CargaHoraria + "\nEmenta: "+ Ementa;
        }

    }
}

