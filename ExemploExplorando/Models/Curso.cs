using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public Curso(string nome){
            Nome = nome;
        }
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarALuno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
            
        }

        public void ListarALunos()
        {
            Console.WriteLine($"Alunos no curso de: {Nome}");

            for (int count = 0; count < Alunos.Count; count++)
            {
                //string texto = "Nº " + count + " - " + Alunos[count].NomeCompleto;
                string texto = $"Nº {count + 1} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            } 
        }
    }
}