using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models.Pessoa
{
    public class Pessoa(string nome, int idade) // Declaração da classe pública Pessoa, que pode ser usada fora desse namespace.
    {
        public string Nome { get; set; } = nome; // Define a propriedade Nome com o valor passado na criação do objeto.
        public int Idade { get; set; } = idade; // Propriedade pública que guarda a idade da pessoa.
        
        public void Apresentar() // Método público que imprime uma mensagem com o nome e a idade da pessoa.
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e eu tenho {Idade} anos!"); // Exibe a apresentação da pessoa no console.
        }
    }
}