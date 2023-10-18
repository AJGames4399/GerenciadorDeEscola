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
                                Console.Clear();
                                Console.WriteLine("\n\n\n\n\n\n" + gerenciarEscola.Matricular());
                                break;
                            case '3':
                                Console.Clear();
                                Console.WriteLine("\n\n\n"+gerenciarEscola.Listar('A'));
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
                                Console.Clear();
                                Console.WriteLine("\n\n\n\n\n\n" + gerenciarEscola.AtribuirDisciplina());
                                break;
                            case '3':
                                Console.Clear();
                                Console.WriteLine("\n\n\n" + gerenciarEscola.Listar('P'));
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
                                Console.Clear();
                                Console.WriteLine("\n\n\n\n\n\n"+ gerenciarEscola.CadastrarCurso());
                                break;
                            case '2':
                                Console.Clear();
                                Console.WriteLine("\n\n\n\n\n\n" + gerenciarEscola.AdicionarDisciplina());
                                break;
                            case '3':
                                Console.Clear();
                                Console.WriteLine("\n\n\n" + gerenciarEscola.Listar('C'));
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
                        Console.WriteLine("2 - Listar Disciplinas");
                        Console.WriteLine("3 - Voltar");
                        switch (Console.ReadKey().KeyChar)
                        {
                            case '1':
                                Console.Clear();
                                Console.WriteLine("\n\n\n\n\n\n"+ gerenciarEscola.CadastrarDisciplina());
                                break;
                            case '2':
                                Console.Clear();
                                Console.WriteLine("\n\n\n" + gerenciarEscola.Listar('D'));
                                break;
                            case '3':
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
        }

    }

}



