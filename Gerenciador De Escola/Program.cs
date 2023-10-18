using System;

namespace Gerenciador_De_Escola
{
    class Program
    {

        //Imagine que você está desenvolvendo um sistema de gerenciamento de escola.
        //
        //Crie o cadastro do Aluno com caracteristicas como nome, idade, número de identificação do aluno(matrícula) e uma lista de cursos
        //em que o aluno está matriculado.Abra a possibilidade que um aluno se matricule em um curso. Crie também uma forma de exibir a lista
        //de cursos em que o aluno está matriculado.
        //
        //Crie o cadastro de Curso com caracteristicas como nome, código do curso, os alunos matriculados no curso e as disciplinas deste curso.
        //Deve-se permitir que um aluno seja adicionado à lista de alunos do curso, assim como as disciplinas.Disponibilize a lista de alunos
        //matriculados no curso. Disponibilize também a lista de disciplinas.
        //
        //Crie o cadastro de Disciplinas com caracteristicas como titulo, carga horária e ementa.
        //
        //Crie o cadastro de Professor com o nome, idade e um conjunto de disciplinas que o professor está lecionando. Permita que uma disciplina
        //seja atribuída a um professor. Disponibilize a lista de cursos + disciplinas que o professor está lecionando.
        //
        //Gerenciar a atribuição de um aluno a um curso e vice-versa onde ambos serão atribuidos um ao outro portanto não deve ser possível
        //adicionar um curso a um aluno sem adicionar o aluno ao curso e vice-versa.



        /*
        Alguns métodos e classes foram implementados. Alguns funcionam bem outros nem tanto, pois não foram muito testados.
        Recursos de validação e tratamentos de exceção então não foram implementados, podemos implementar mais pra frente.
        Talvez descentralizar um pouco mais o código, caso ele esteja muito centralizado na classe gerenciar escola.
        Eu também fugi um pouco da uml, porém qualquer coisa gente adapta depois.

        */

        static void Main()
        {
            GerenciarEscola gerenciarEscola = new GerenciarEscola();
            bool bSair = false;
            while (!bSair)
            {
                Console.WriteLine("\nMenu do Sistema de Gerenciamento de Escola:");
                Console.WriteLine("1 - Aluno");
                Console.WriteLine("2 - Professor");
                Console.WriteLine("3 - Curso");
                Console.WriteLine("4 - Disciplina");
                Console.WriteLine("5 - Sair");
                Console.WriteLine("\nInsira o numero referente a opção: ");
                Console.SetCursorPosition(35,8);
                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        Console.Clear();
                        Console.WriteLine("\nOpções Referentes Aos Alunos");
                        Console.WriteLine("1 - Cadastrar Aluno");
                        Console.WriteLine("2 - Matricular Aluno a um curso");
                        Console.WriteLine("3 - Listar Alunos");
                        Console.WriteLine("4 - Voltar");
                        Console.WriteLine("\nInsira o numero referente a opção: ");
                        Console.SetCursorPosition(35, 7);
                        switch (Console.ReadKey().KeyChar)
                        {
                            case '1':
                                Console.Clear();
                                Console.WriteLine("\n\n\n\n\n\n" + gerenciarEscola.Cadastrar('A'));
                                break;
                            case '2':
                                break;
                            case '3':
                                break;
                            case '4':
                                Console.WriteLine("\n\nVoltando ao menu principal");
                                break;
                            default:
                                Console.WriteLine("\n\nOpção Invalida!!! ");
                                break;
                        }
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine("Opções Referentes Ao Professores");
                        Console.WriteLine("1 - Cadastrar Professor");
                        Console.WriteLine("2 - Atribuir Disciplina");
                        Console.WriteLine("3 - Listar Professores");
                        Console.WriteLine("4 - Voltar");
                        switch(Console.ReadKey().KeyChar)
                        {
                            case '1':
                                Console.Clear();
                                Console.WriteLine("\n\n\n\n\n\n"+ gerenciarEscola.Cadastrar('P'));
                                break;
                            case '2':
                                break;
                            case '3':
                                break;
                            case '4':
                                Console.WriteLine("\n\nVoltando ao menu principal");
                                break;
                            default:
                                Console.WriteLine("\n\nOpção Invalida!!! ");
                                break;
                        }
                        break;
                    case '3':
                        Console.Clear();
                        Console.WriteLine("Opções Referente Ao Curso");
                        Console.WriteLine("1 - Cadastrar Curso");
                        Console.WriteLine("2 - Adicionar Disciplina");
                        Console.WriteLine("3 - Listar Cursos");
                        Console.WriteLine("4 - Voltar");
                        switch (Console.ReadKey().KeyChar)
                        {
                            case '1':
                                break;
                            case '2':
                                break;
                            case '3':
                                break;
                            case '4':
                                Console.WriteLine("\n\nVoltando ao menu principal");
                                break;
                            default:
                                Console.WriteLine("\n\nOpção Invalida!!! ");
                                break;
                        }
                        break;
                    case '4':
                        Console.Clear();
                        Console.WriteLine("Opções Referente A Disciplina");
                        Console.WriteLine("1 - Cadastrar Disciplina");
                        Console.WriteLine("2 - Atribuir Professor");
                        Console.WriteLine("3 - Listar Disciplinas");
                        Console.WriteLine("4 - Voltar");
                        switch (Console.ReadKey().KeyChar)
                        {
                            case '1':
                                break;
                            case '2':
                                break;
                            case '3':
                                break;
                            case '4':
                                Console.WriteLine("\n\nVoltando ao menu principal");
                                break;
                            default:
                                Console.WriteLine("\n\nOpção Invalida!!! ");
                                break;
                        }
                        break;
                    case '5':
                        Console.WriteLine("\n\nObrigado por usar o programa");
                        bSair = true;
                        break;
                    default:
                        Console.WriteLine("\n\nOpção Invalida!!! ");
                        break;
                }
                Thread.Sleep(1500);
                Console.Clear();
            }
            //GerenciarEscola gerenciarEscola = new GerenciarEscola();
            //string nome;
            //int idade;
            //int matricula;
            //int codigoCurso;
            //string titulo;
            //int cargaHoraria;
            //string ementa;

            //while (true)
            //{
            //    Console.WriteLine("\nMenu do Sistema de Gerenciamento de Escola:");
            //    Console.WriteLine("1. Cadastrar Aluno");
            //    Console.WriteLine("2. Cadastrar Professor");
            //    Console.WriteLine("3. Cadastrar Curso");
            //    Console.WriteLine("4. Cadastrar Disciplina");
            //    Console.WriteLine("5. Matricular Aluno em Curso");
            //    Console.WriteLine("6. Atribuir Disciplina a Professor");
            //    Console.WriteLine("7. Listar Alunos");
            //    Console.WriteLine("8. Listar Professores");
            //    Console.WriteLine("9. Listar Cursos");
            //    Console.WriteLine("10. Listar Disciplinas");
            //    Console.WriteLine("11. Sair");
            //    Console.Write("Digite sua escolha: ");

            //    int escolha = int.Parse(Console.ReadLine());

            //    switch (escolha)
            //    {
            //        case 1:
            //            Console.Write("Digite o nome do aluno: ");
            //            nome = Console.ReadLine();
            //            Console.Write("Digite a idade do aluno: ");
            //            idade = int.Parse(Console.ReadLine());
            //            Console.Write("Digite a matrícula do aluno: ");
            //            matricula = int.Parse(Console.ReadLine());
            //            gerenciarEscola.CadastrarAluno(nome, idade, matricula);
            //            break;

            //        case 2:
            //            Console.Write("Digite o nome do professor: ");
            //            nome = Console.ReadLine();
            //            Console.Write("Digite a idade do professor: ");
            //            idade = int.Parse(Console.ReadLine());
            //            gerenciarEscola.CadastrarProfessor(nome, idade);

            //            break;

            //        case 3:
            //            Console.Write("Digite o nome do curso: ");
            //            nome = Console.ReadLine();
            //            Console.Write("Digite o código do curso: ");
            //            codigoCurso = int.Parse(Console.ReadLine());
            //            gerenciarEscola.CadastrarCurso(nome, codigoCurso);
            //            break;

            //        case 4:
            //            Console.Write("Digite o título da disciplina: ");
            //            titulo = Console.ReadLine();
            //            Console.Write("Digite a carga horária da disciplina: ");
            //            cargaHoraria = int.Parse(Console.ReadLine());
            //            Console.Write("Digite a ementa da disciplina: ");
            //            ementa = Console.ReadLine();
            //            gerenciarEscola.CadastrarDisciplina(titulo, cargaHoraria, ementa);

            //            break;

            //        case 5:
            //            gerenciarEscola.MatricularAlunoEmCurso();
            //            break;

            //        case 6:
            //            gerenciarEscola.AtribuirDisciplinaAProfessor();
            //            break;

            //        case 7:
            //            gerenciarEscola.ListarAlunos();
            //            break;

            //        case 8:
            //            gerenciarEscola.ListarProfessores();
            //            break;

            //        case 9:
            //            gerenciarEscola.ListarCursos();
            //            break;

            //        case 10:
            //            gerenciarEscola.ListarDisciplinas();
            //            break;

            //        case 11:
            //            Console.WriteLine("Saindo do sistema...");
            //            Environment.Exit(0);
            //            break;

            //        default:
            //            Console.WriteLine("Opção inválida.");
            //            break;
            //    }
            //}
        }

    }

}



