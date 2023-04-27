using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex1
{
    public class Pessoa
    {
<<<<<<< HEAD
        private String _nome;
        protected int idade { get; set; }
        public String endereco { get; set; }
=======
        private String Nome;
        protected int Idade { get; set; }
        public String Endereco { get; set; }
>>>>>>> 2c372b17c8ebdc3d065fa7a46200a84d82de7aeb

        public Pessoa()
        {
            
        }

        public Pessoa(String nome, int idade)
        {
<<<<<<< HEAD
            _nome = nome;
            this.idade = idade;
        }

        public void saudacao() {
            Console.WriteLine($"Olá, meu nome é {_nome} e eu tenho {idade} anos");
=======
            Nome = nome;
            Idade = idade;
        }

        public void saudacao() {
            Console.WriteLine($"Olá, meu nome é {Nome} e eu tenho {Idade} anos");
>>>>>>> 2c372b17c8ebdc3d065fa7a46200a84d82de7aeb
        }
  
    }

}