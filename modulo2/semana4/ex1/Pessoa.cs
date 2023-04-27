using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex1
{
    public class Pessoa
    {
        private String Nome;
        protected int Idade { get; set; }
        public String Endereco { get; set; }

        public Pessoa()
        {
            
        }

        public Pessoa(String nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void saudacao() {
            Console.WriteLine($"Olá, meu nome é {Nome} e eu tenho {Idade} anos");
        }
  
    }

}