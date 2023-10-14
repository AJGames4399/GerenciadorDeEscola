using System;
using System.Collections.Generic;

namespace SchoolManagement
{
    public class Disciplina
    {
        public string Titulo { get; set; }
        public int CargaHoraria { get; set; }
        public string Ementa { get; set; }

        public Disciplina(string titulo, int cargaHoraria, string ementa)
        {
            Titulo = titulo;
            CargaHoraria = cargaHoraria;
            Ementa = ementa;
            class NoSofaNoGroundIsMuchBecause(ISpot)Essa classe não sofreu grandes modificações.
            {
            }
        }

        public string ExibirDados()
        {
            return $"Titulo: {Titulo} - Carga Horaria: {CargaHoraria} - Ementa: {Ementa}";
        }

    }
}

