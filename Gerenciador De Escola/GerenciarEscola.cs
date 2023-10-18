using System;
using System.Collections.Generic;
using System.Globalization;

namespace Gerenciador_De_Escola
{

    /*
        Essa é uma classe centralizadora Para gerenciar os métodos e classes desse sistema.
        Porém, talvez ela tenha ficado muito grande e com muitas responsabilidades.
        Não sei o que você acha, mas talvez seja interessante a gente tentar descentralizar um pouco mais. Ou talvez desmembrar alguns métodos.
        Alguns recursos de validação foram implementados, apenas para exemplo. Porem, talvez seja interessante a gente criar uma classe para tratar exceções, etc.
        Também pode ter alguns métodos que não estejam associados a outros. Um exemplo, é quando listamos os cursos e não aparece nenhuma disciplina associada.
         Alguns métodos e classes foram implementados. Alguns funcionam bem outros nem tanto, pois não foram muito testados.

        Muitas classes daqui, precisam ficar nos objetos, mas pode servir como ponte pra conversar entre os metodos e tbm para gerar as mensagens a serem apresentadas na tela,
        por hora deixei comentado enquanto revisamos e organizamos os objetos, deixemos esta classe para quando todos os objetos estiverem prontos

     */

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
            Console.SetCursorPosition(17, 8);
            dataNascimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
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
                    Alunos.Add(new Aluno(sNome, dataNascimento));
                }
                else
                {
                    Professores.Add(new Professor(sNome, dataNascimento));
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


        //public GerenciarEscola()
        //{
        //    Alunos = new List<Aluno>();
        //    Professores = new List<Professor>();
        //    Disciplinas = new List<Disciplina>();
        //    Cursos = new List<Curso>();
        //}

        //public void CadastrarAluno(string nome, int idade, int matricula)
        //{

        //    Aluno aluno = new Aluno();
        //    Alunos.Add(Aluno);

        //}

        //public void CadastrarProfessor(string nome, int idade)
        //{

        //    Professor professor = new Professor(nome, idade);
        //    Professores.Add(professor);

        //}

        //public void CadastrarCurso(string nome, int codigoCurso)
        //{

        //    Curso curso = new Curso(nome, codigoCurso);
        //    Cursos.Add(curso);

        //}

        //public void CadastrarDisciplina(string titulo, int cargaHoraria, string ementa)
        //{
        //    Disciplina disciplina = new Disciplina(titulo, cargaHoraria, ementa);
        //    Disciplinas.Add(disciplina);

        //}

        //public void MatricularAlunoEmCurso()
        //{
        //    int numAluno = 0;
        //    int numCurso = 0;

        //    if (Alunos.Count == 0)
        //    {
        //        Console.WriteLine("Não há alunos cadastrados");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Alunos disponíveis para matrícula:");
        //        for (int i = 0; i < Alunos.Count; i++)
        //        {
        //            Console.WriteLine($"{i + 1}. {Alunos[i].Nome}");
        //        }

        //        Console.Write("Selecione o número do aluno: ");
        //        numAluno = int.Parse(Console.ReadLine()) - 1;
        //    }

        //    if (Cursos.Count == 0)
        //    {
        //        Console.WriteLine("Não há cursos cadastrados");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Cursos disponíveis para matrícula:");
        //        for (int i = 0; i < Cursos.Count; i++)
        //        {
        //            Console.WriteLine($"{i + 1}. {Cursos[i].Nome}");
        //        }

        //        Console.Write("Selecione o número do curso: ");
        //        numCurso = int.Parse(Console.ReadLine()) - 1;
        //    }

        //    if (Alunos.Count > 0 && Cursos.Count > 0)
        //    {
        //        Alunos[numAluno].Matricular(Cursos[numCurso]);
        //        Console.WriteLine($"Aluno {Alunos[numAluno].Nome} matriculado no curso {Cursos[numCurso].Nome}.");
        //    }


        //}

        //public void AtribuirDisciplinaAProfessor()
        //{

        //    int numProfessor = 0;
        //    int numDisciplina = 0;

        //    if (Professores.Count == 0)
        //    {
        //        Console.WriteLine("Não há professores cadastrados");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Professores disponíveis para atribuição:");
        //        for (int i = 0; i < Professores.Count; i++)
        //        {
        //            Console.WriteLine($"{i + 1}. {Professores[i].Nome}");
        //            Console.Write("Selecione o número do professor: ");
        //            numProfessor = int.Parse(Console.ReadLine()) - 1;
        //        }

        //    }

        //    if (Disciplinas.Count == 0)
        //    {
        //        Console.WriteLine("Não há disciplinas cadastradas");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Disciplinas disponíveis para atribuição:");
        //        for (int i = 0; i < Disciplinas.Count; i++)
        //        {
        //            Console.WriteLine($"{i + 1}. {Disciplinas[i].Titulo}");
        //        }
        //        Console.Write("Selecione o número da disciplina: ");
        //        numDisciplina = int.Parse(Console.ReadLine()) - 1;
        //    }

        //    if (Professores.Count > 0 && Disciplinas.Count > 0)
        //    {
        //        Professores[numProfessor].AlocarDisciplina(Disciplinas[numDisciplina]);
        //        Console.WriteLine($"Disciplina {Disciplinas[numDisciplina].Titulo} alocada para o professor {Professores[numProfessor].Nome}.");
        //    }


        //}

        //public void ListarAlunos()
        //{

        //}

        //public void ListarProfessores()
        //{
        //    Console.WriteLine("Lista de Professores:");
        //    foreach (var professor in Professores)
        //    {
        //        professor.ExibirDados();
        //    }
        //}

        //public void ListarCursos()
        //{
        //    // Esse método mostre alguns cursos, porém não existe as disciplinas associadas a ele. Talvez seja interessante implementar isso.
        //    Console.WriteLine("Lista de Cursos:");
        //    foreach (var curso in Cursos)
        //    {
        //        Console.WriteLine($"Nome: {curso.Nome}, Código: {curso.CodigoCurso}");
        //    }
        //}

        //public void ListarDisciplinas()
        //{

        //}


    }
}

