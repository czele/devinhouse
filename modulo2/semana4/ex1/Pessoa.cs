using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex1
{
    public class Pessoa {

        private String _nome;
        protected int idade { get; set; }
        public String endereco { get; set; }

        public Pessoa()
        {
            
        }

        public Pessoa(String nome, int idade)
        {
            _nome = nome;
            this.idade = idade;
        }

        public void saudacao() {
            Console.WriteLine($"Olá, meu nome é {_nome} e eu tenho {idade} anos");

        }

    }

}