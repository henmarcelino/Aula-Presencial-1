﻿using Controllers;
using Modelos;
using System;

namespace ConsoleView
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ProfessoresController professorController = new ProfessoresController();

            // Cadastrando professores
            Professor p = CadastrarProfessor();
            professorController.Inserir(p);
            
            
            DisciplinasController disciplinaController = new DisciplinasController();

            //Cadastro disciplinas

            Disciplina d = CadastrarDisciplina();
            disciplinaController.Inserir(d);
            

            AlunosController alunosController = new AlunosController();

            // Cadastrando alunos
            Aluno a = CadastrarAluno();
            alunosController.Inserir(a);

            Aluno b = CadastrarAluno();
            alunosController.Inserir(b);

            Aluno c = CadastrarAluno();
            alunosController.Inserir(c);

            Console.Clear();

            foreach (Professor professor in professorController.ListarTodos())
            {
                ImprimirDadosProfessor(professor);
            }

            foreach (Disciplina disciplina in disciplinaController.ListarTodos())
            {
                ImprimirDadosDisciplina(disciplina);
            }

            foreach (Aluno aluno in alunosController.ListarTodos())
            {
                ImprimirDadosAluno(aluno);
            }





            // ImprimirDadosAluno(a);

            Console.ReadKey();

            
        }

        private static void ImprimirDadosDisciplina(Disciplina disciplina)
        {
            Console.WriteLine("Materia: " + disciplina.Materia);
            Console.WriteLine("Ciclo: " + disciplina.Ciclo);
        }

        private static Disciplina CadastrarDisciplina()
        {
            Disciplina a = new Disciplina();

            Console.WriteLine("Digite a Matéria: ");
            a.Materia = (Console.ReadLine());
            Console.WriteLine("Digite o Ciclo: ");
            a.Ciclo = int.Parse(Console.ReadLine());
            return a;
        }

        private static void ImprimirDadosProfessor(Professor professor)
        {
            Console.WriteLine("Professor: " + professor.Nome);
            Console.WriteLine("Cadastro: " + professor.Cadastro);
        }

        private static Professor CadastrarProfessor()
        {
            Professor a = new Professor();

            Console.WriteLine("Digite o Professor: ");
            a.Nome = (Console.ReadLine());
            Console.WriteLine("Digite o Cadastro: ");
            a.Cadastro = int.Parse(Console.ReadLine());
            return a;
        }

        private static void ImprimirDadosAluno(Aluno a)
        {
            Console.WriteLine("Aluno: " + a.Nome);
            Console.WriteLine("Matricula: " + a.Matricula);
        }

        private static Aluno CadastrarAluno()
        {
            Aluno a = new Aluno();

            Console.WriteLine("Digite o Aluno: ");
            a.Nome = Console.ReadLine();

            Console.WriteLine("Digite o Matricula: ");
            a.Matricula = int.Parse(Console.ReadLine());
            return a;
        }
    }
}
