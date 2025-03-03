using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
            
        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }
        private string _nome;
        private int _idade;
        public string Nome
        {
            //Body Expressions é utilizado para referenciar em apenas uma linha;
            get => _nome.ToUpper();
                  
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("\n\nO NOME NÃO PODE SER EM BRANCO!!\n");
                }
                _nome = value;
            }
             
        }
        public string Sobrenome{ get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade 
        {
            get => _idade;
            
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("\n\nA IDADE NÃO PODE SER NEGATIVA!");
                }

                _idade = value;
            } 
        
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}\nIdade {Idade}");
        }
    }
}