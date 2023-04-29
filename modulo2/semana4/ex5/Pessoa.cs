using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex5
{
    public class Pessoa
    {
        private String nome;
        private int idade;

        public Pessoa() { }

        public String Nome {
            get { return nome; }
            set { nome = value; }
        }

        public int Idade {
            get { return idade; }
            set { idade = value; }
        }

        public void DefinirIdade(int idade) {
            if(idade>0) {
                this.idade = idade;
                Console.WriteLine($"Idade positiva de {idade}");
            } else {
                Console.WriteLine("Idade negativa");
            }   
        }
    }
}