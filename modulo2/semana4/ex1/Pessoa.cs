using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex1
{
    public class Pessoa
    {
        private String nome { get; set; }
        protected int idade { get; set; }
        public String endereco { get; set; }

        public Pessoa()
        {
            
        }

        public Pessoa(String Nome, int Idade)
        {
            nome = Nome;
            idade = Idade;
        }

        public string getNome() {
            return nome;
        }

        public int getIdade() {
            return idade;
        }

    }
}