using static System.Net.Mime.MediaTypeNames;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
namespace Gerenciador_De_Escola
{
    internal class Program
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

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}