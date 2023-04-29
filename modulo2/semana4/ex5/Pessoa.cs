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
        
        public void DefinirNome(String nome) {
            this.nome = nome;
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