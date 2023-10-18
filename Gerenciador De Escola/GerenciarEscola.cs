using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Emit;

namespace Gerenciador_De_Escola
{
    public class GerenciarEscola
    {
        private List<Aluno> Alunos;
        private List<Professor> Professores;
        private List<Curso> Cursos;
        private List<Disciplina> Disciplinas;

        public GerenciarEscola() 
        {
            Alunos = new List<Aluno>();
            Professores = new List<Professor>();
            Cursos = new List<Curso>();
            Disciplinas = new List<Disciplina>();
        }
        public string Cadastrar(char Tipo)
        {
            char cOpcao = ' ';
            int iMatricula = 0;
            string sNome = "";
            DateTime dataNascimento = new DateTime();

            if (Tipo == 'A')
            {
                iMatricula = Alunos.Count;
                Console.WriteLine("\nCadastrar Novo Aluno");
            }
            else 
            {
                iMatricula = Professores.Count;
                Console.WriteLine("\nCadastrar Novo Professor");
            }
            Console.WriteLine("\n\nMatricula: "+iMatricula);
            Console.WriteLine("\nNome Completo: __________________________________________");
            Console.WriteLine("\nData Nascimento: _________  (DD/MM/AAAA)");
            Console.WriteLine("\nIdade: ");
        labelNovoCadastro:
            Console.SetCursorPosition(15, 6);
            sNome = Console.ReadLine();
        LabelErroData:
            Console.SetCursorPosition(17, 8); 
            try
            {
                dataNascimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                Console.SetCursorPosition(17, 8);
                Console.WriteLine("_________  (DD/MM/AAAA)");
                goto LabelErroData;
            }
            
            Console.SetCursorPosition(7, 10);
            if(dataNascimento.Day >= DateTime.Today.Day && dataNascimento.Month >= DateTime.Today.Month)
            {
                Console.WriteLine((DateTime.Today.Year-dataNascimento.Year)-1+" Anos");
            }
            else
            {
                Console.WriteLine(DateTime.Today.Year - dataNascimento.Year + " Anos");
            }
            Console.WriteLine("\n\nConfirma: \nS - Sim\nN - Não\nC - Cancelar");
        labelConfirmaOpcao:
            Console.SetCursorPosition(10, 13);
            cOpcao = char.ToUpper(Console.ReadKey().KeyChar);
            if (cOpcao == 'S')
            {
                if(Tipo == 'A')
                {
                    Alunos.Add(new Aluno(iMatricula, sNome, dataNascimento));
                }
                else
                {
                    Professores.Add(new Professor(iMatricula, sNome, dataNascimento));
                }
            }
            else if (cOpcao == 'N')
            {
                Console.SetCursorPosition(15, 6);
                Console.WriteLine("__________________________________________");
                Console.SetCursorPosition(17, 8);
                Console.WriteLine("_________  (DD/MM/AAAA)");
                Console.SetCursorPosition(7, 10);
                Console.WriteLine("          ");
                goto labelNovoCadastro;
            }
            else if (cOpcao == 'C')
            {
                return "Cadastro Cancelado";
            }
            else
            {
                Console.SetCursorPosition(13, 13);
                Console.WriteLine("<Opcao Invalida>");
                goto labelConfirmaOpcao;
            }

            return "Cadastrado Com Sucesso!";
        }

        public string CadastrarCurso()
        {
            int iCodigoCurso = Cursos.Count;
            string sNome = "";
            char cOpcao = ' ';
            Console.WriteLine("\nCadastrar Novo Curso");
            Console.Write("\n\nCodigo Do Curso: "+iCodigoCurso);
            Console.WriteLine("\nNome Do Curso: ___________________________________________________");
        labelNovoCadastro:
            Console.SetCursorPosition(15,5);
            sNome = Console.ReadLine();
            Console.WriteLine("\n\nConfirma: \nS - Sim\nN - Não\nC - Cancelar");
        labelConfirmaOpcao:
            Console.SetCursorPosition(10, 8);
            cOpcao = char.ToUpper(Console.ReadKey().KeyChar);
            if (cOpcao == 'S')
            {
                Cursos.Add(new Curso(iCodigoCurso, sNome));
            }
            else if (cOpcao == 'N')
            {
                Console.SetCursorPosition(14,6);
                Console.WriteLine("___________________________________________________");
                goto labelNovoCadastro;
            }
            else if (cOpcao == 'C')
            {
                return "Cadastro Cancelado";
            }
            else
            {
                Console.SetCursorPosition(13, 8);
                Console.WriteLine("<Opcao Invalida>");
                goto labelConfirmaOpcao;
            }

            return "Curso Cadastrado Com Sucesso!";
        }

        public string CadastrarDisciplina(){
            string sNome = "";
            string sEmenta = "";
            int iCargaHoraria = 0;
            int iCodigoDisciplina = Disciplinas.Count;
            char cOpcao = ' ';

            Console.WriteLine("\nCadastrar Nova disciplina");
            Console.WriteLine("\n\nCodigo Da Disciplina: "+iCodigoDisciplina);
            Console.WriteLine("\nNome Da Disciplina: ");
            Console.WriteLine("\nCarga Horaria: ");
            Console.WriteLine("\nEmenta:\n ___________________________________________________________________________________________________");
        labelNovoCadastro:
            Console.SetCursorPosition(20,6);
            sNome = Console.ReadLine();
            Console.SetCursorPosition(15,8);
            try
            {
                iCargaHoraria = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.SetCursorPosition(20, 6);
                Console.WriteLine("                                                                                 ");
                Console.SetCursorPosition(18,8);
                Console.WriteLine("<Carga Horaria Invalida>");
                Thread.Sleep(1500);
                Console.SetCursorPosition(18,8);
                Console.WriteLine("                           ");
                goto labelNovoCadastro;
            }
            Console.SetCursorPosition(1,11);
            sEmenta = Console.ReadLine();
            Console.WriteLine("\n\nConfirma: \nS - Sim\nN - Não\nC - Cancelar");
        labelConfirmaOpcao:
            Console.SetCursorPosition(10, 14);
            cOpcao = char.ToUpper(Console.ReadKey().KeyChar);
            if (cOpcao == 'S')
            {
                Disciplinas.Add(new Disciplina(iCodigoDisciplina, sNome, iCargaHoraria, sEmenta));
            }
            else if (cOpcao == 'N')
            {
                Console.SetCursorPosition(1,11);
                Console.WriteLine("___________________________________________________________________________________________________");
                goto labelNovoCadastro;
            }
            else if (cOpcao == 'C')
            {
                return "Cadastro Cancelado";
            }
            else
            {
                Console.SetCursorPosition(13, 14);
                Console.WriteLine("<Opcao Invalida>");
                goto labelConfirmaOpcao;
            }
            return "Disciplina Cadastrada Com Sucesso";
        }

        public string Listar(char tipo){
            string sTipoLista = "";
            int iNumeroCadastros = 0;
            switch(tipo){
                case 'A':
                    Console.WriteLine("Lista De Alunos Cadastrados\n");
                    foreach(var aluno in Alunos)
                    {
                        Console.WriteLine(aluno.ExibirDados());
                    }
                    break;
                case 'P':
                    Console.WriteLine("Lista De Professores Cadastrados\n");
                    foreach(var professor in Professores)
                    {
                        Console.WriteLine(professor.ExibirDados());
                    }
                    break;
                case 'C':
                    Console.WriteLine("Lista De Cursos Cadastrados\n");
                    foreach(var curso in Cursos)
                    {
                        Console.WriteLine(curso.ExibirDados());
                    }
                    break;
                case 'D':
                    Console.WriteLine("Lista De Disciplinas Cadastradas\n");
                    foreach(var disciplina in Disciplinas)
                    {
                        disciplina.ExibirDados();
                    }
                    break;
                default:
                    return "Erro";
                    break;
            }   
            Console.WriteLine("\n\n\nPressione quaçquer tecla para sair");
            Console.ReadKey();
            return "Voltando...";
        }

        public string Matricular()
        {
            char cOpcao = ' ';
            Aluno AlunoSelecionado;
            Curso CursoSelecionado;

            Console.WriteLine("\nMatricular Aluno A Um Curso");
            Console.WriteLine("Matricula Do Aluno:");
            Console.WriteLine("Nome:");
            Console.WriteLine("Codigo Do Curso:");
            Console.WriteLine("Nome:");
        labelNovaMatricula:
            Console.SetCursorPosition(20,2);
            try {
                AlunoSelecionado = Alunos.Find(x => x.MatriculaAluno == int.Parse(Console.ReadLine()));
            }
            catch (Exception ex)
            {
                Console.SetCursorPosition(20, 2);
                Console.WriteLine("     ");
                goto labelNovaMatricula;
            }
            Console.SetCursorPosition(6,3);
            try { 
                Console.WriteLine(AlunoSelecionado.Nome);
            }
            catch (Exception ex)
            {
                Console.SetCursorPosition(13, 8);
                Console.WriteLine("<Aluno Nao Encontrado>");
                Thread.Sleep(1500);
                Console.SetCursorPosition(13, 8);
                Console.WriteLine("                           ");
                goto labelNovaMatricula;
            }
            Console.SetCursorPosition(17,4);
            try {
                CursoSelecionado = Cursos.Find(x => x.CodigoCurso == int.Parse(Console.ReadLine()));
            }
            catch (Exception ex)
            {
                Console.SetCursorPosition(17,4);
                Console.WriteLine("     ");
                goto labelNovaMatricula;
            }
            Console.SetCursorPosition(6,5);
            try {
                Console.WriteLine(CursoSelecionado.Nome);
            }
            catch (Exception ex)
            {
                Console.SetCursorPosition(13, 8);
                Console.WriteLine("<Curso Nao Encontrado>");
                Thread.Sleep(1500);
                Console.SetCursorPosition(13, 8);
                Console.WriteLine("                           ");
                goto labelNovaMatricula;
            }
            Console.WriteLine("\n\nConfirma: \nS - Sim\nN - Não\nC - Cancelar");
        labelConfirmaOpcao:
            Console.SetCursorPosition(10, 8);
            cOpcao = char.ToUpper(Console.ReadKey().KeyChar);
            if (cOpcao == 'S')
            {
                if(!AlunoSelecionado.Cursos.Contains(CursoSelecionado) && !CursoSelecionado.Alunos.Contains(AlunoSelecionado)){
                    Alunos.Find(x => x.MatriculaAluno == AlunoSelecionado.MatriculaAluno).Matricular(CursoSelecionado);
                    Cursos.Find(x => x.CodigoCurso == CursoSelecionado.CodigoCurso).AdicionarAluno(AlunoSelecionado);
                }else{
                    return "Aluno Ja Matriculado Neste Curso";
                }
            }
            else if (cOpcao == 'N')
            {
                Console.SetCursorPosition(20,2);
                Console.WriteLine("     ");
                Console.SetCursorPosition(6,3);
                Console.WriteLine("                                                                           ");
                Console.SetCursorPosition(17,4);
                Console.WriteLine("     ");
                Console.SetCursorPosition(6,5);
                Console.WriteLine("                                                                           ");
                goto labelNovaMatricula;
            }
            else if (cOpcao == 'C')
            {
                return "Matricula Cancelada";
            }
            else
            {
                Console.SetCursorPosition(13, 8);
                Console.WriteLine("<Opcao Invalida>");
                goto labelConfirmaOpcao;
            }
            return "Aluno Matriculado com Sucesso";
        }

        public string AtribuirDisciplina()
        {
            char cOpcao = ' ';
            Professor professorSelecionado;
            Disciplina disciplinaSelecionada;
            Console.WriteLine("\nAtribuir Disciplina A Um Professor");
            Console.WriteLine("Matricula Do Professor:");
            Console.WriteLine("Nome: ");
            Console.WriteLine("Codigo Da Disciplina:");
            Console.WriteLine("Nome: ");
        labelNovaAtribuicao:
            Console.SetCursorPosition(24,2);
            try
            {
                professorSelecionado = Professores.Find(x => x.matriculaProfessor == int.Parse(Console.ReadLine()));
            }
            catch (Exception ex)
            {
                Console.SetCursorPosition(24, 2);
                Console.WriteLine("     ");
                goto labelNovaAtribuicao;
            }
            Console.SetCursorPosition(6,3);
            try { 
                Console.WriteLine(professorSelecionado.Nome);
            }
            catch (Exception ex)
            {
                Console.SetCursorPosition(13, 8);
                Console.WriteLine("<Professor Nao Encontrado>");
                Thread.Sleep(1500);
                Console.SetCursorPosition(13, 8);
                Console.WriteLine("                           ");
                goto labelNovaAtribuicao;
            }
            Console.SetCursorPosition(22,4);
            try {
                disciplinaSelecionada = Disciplinas.Find(x => x.CodigoDisciplina == int.Parse(Console.ReadLine()));
            }
            catch (Exception ex)
            {
                Console.SetCursorPosition(22, 4);
                Console.WriteLine("     ");
                goto labelNovaAtribuicao;
            }
            Console.SetCursorPosition(6, 5);
            try
            {
                Console.WriteLine(disciplinaSelecionada.Nome);
            }
            catch (Exception ex)
            {
                Console.SetCursorPosition(13, 8);
                Console.WriteLine("<Disciplina Nao Encontrada>");
                Thread.Sleep(1500);
                Console.SetCursorPosition(13, 8);
                Console.WriteLine("                           ");
                goto labelNovaAtribuicao;
            }
            Console.WriteLine("\n\nConfirma: \nS - Sim\nN - Não\nC - Cancelar");
        labelConfirmaOpcao:
            Console.SetCursorPosition(10, 8);
            cOpcao = char.ToUpper(Console.ReadKey().KeyChar);
            if (cOpcao == 'S')
            {
                if (!professorSelecionado.Disciplinas.Contains(disciplinaSelecionada))
                {
                    Professores.Find(x => x.matriculaProfessor == professorSelecionado.matriculaProfessor).AlocarDisciplina(disciplinaSelecionada);
                }
                else
                {
                    return "Aluno Ja Matriculado Neste Curso";
                }
            }
            else if (cOpcao == 'N')
            {
                Console.SetCursorPosition(24,2);
                Console.WriteLine("     ");
                Console.SetCursorPosition(6,3);
                Console.WriteLine("                                                                                ");
                Console.SetCursorPosition(22,4);
                Console.WriteLine("     ");
                Console.SetCursorPosition(6,5);
                Console.WriteLine("                                                                                ");
                goto labelNovaAtribuicao;
            }
            else if (cOpcao == 'C')
            {
                return "Atribuicao Cancelada";
            }
            else
            {
                Console.SetCursorPosition(13,8);
                Console.WriteLine("<Opcao Invalida>");
                goto labelConfirmaOpcao;
            }
            return "Disciplina Atribuida Ao Professor Com Sucesso";
        }
        public string AdicionarDisciplina()
        {
            char cOpcao = ' ';
            Disciplina disciplinaSelecionada;
            Curso cursoSelecionado;
            Console.WriteLine("\nAdicionar Disciplina A Um Curso");
            Console.WriteLine("Codigo Da Disciplina:");
            Console.WriteLine("Nome: ");
            Console.WriteLine("Matricula Do Curso:");
            Console.WriteLine("Nome: ");
        labelNovaAdicao:
            Console.SetCursorPosition(22, 2);
            try
            {
                disciplinaSelecionada = Disciplinas.Find(x => x.CodigoDisciplina == int.Parse(Console.ReadLine()));
            }
            catch (Exception ex)
            {
                Console.SetCursorPosition(22, 2);
                Console.WriteLine("     ");
                goto labelNovaAdicao;
            }
            Console.SetCursorPosition(6, 3);
            try { 
                Console.WriteLine(disciplinaSelecionada.Nome);
            }
            catch (Exception ex)
            {
                Console.SetCursorPosition(13, 8);
                Console.WriteLine("<Disciplina Nao Encontrada>");
                Thread.Sleep(1500);
                Console.SetCursorPosition(13, 8);
                Console.WriteLine("                           ");
                goto labelNovaAdicao;
            }
            Console.SetCursorPosition(20, 4);
            try
            {
                cursoSelecionado = Cursos.Find(x => x.CodigoCurso == int.Parse(Console.ReadLine()));
            }
            catch (Exception ex)
            {
                Console.SetCursorPosition(20, 4);
                Console.WriteLine("     ");
                goto labelNovaAdicao;
            }
            Console.SetCursorPosition(6, 5);
            try { 
                Console.WriteLine(cursoSelecionado.Nome);
            }
            catch (Exception ex)
            {
                Console.SetCursorPosition(13, 8);
                Console.WriteLine("<Curso Nao Encontrado>");
                Thread.Sleep(1500);
                Console.SetCursorPosition(13, 8);
                Console.WriteLine("                           ");
                goto labelNovaAdicao;
            }
            Console.WriteLine("\n\nConfirma: \nS - Sim\nN - Não\nC - Cancelar");
        labelConfirmaOpcao:
            Console.SetCursorPosition(10, 8);
            cOpcao = char.ToUpper(Console.ReadKey().KeyChar);
            if (cOpcao == 'S')
            {
                if (!cursoSelecionado.Disciplinas.Contains(disciplinaSelecionada))
                {
                    Cursos.Find(x => x.CodigoCurso == cursoSelecionado.CodigoCurso).AdicionarDisciplina(disciplinaSelecionada);
                }
                else
                {
                    return "Disciplina Já Existente No Curso";
                }
            }
            else if (cOpcao == 'N')
            {
                Console.SetCursorPosition(22, 2);
                Console.WriteLine("     ");
                Console.SetCursorPosition(6, 3);
                Console.WriteLine("                                                                                ");
                Console.SetCursorPosition(20, 4);
                Console.WriteLine("     ");
                Console.SetCursorPosition(6, 5);
                Console.WriteLine("                                                                                ");
                goto labelNovaAdicao;
            }
            else if (cOpcao == 'C')
            {
                return "Adicao Cancelada";
            }
            else
            {
                Console.SetCursorPosition(13, 8);
                Console.WriteLine("<Opcao Invalida>");
                goto labelConfirmaOpcao;
            }
            return "Disciplina Adicionada Ao Curso com Sucesso";
        }
    }
}

