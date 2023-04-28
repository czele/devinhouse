using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex3
{
    public class Cliente
    {
        private String nome { get; set; }
        private String cpf { get; set; }

        public Cliente() { }

        public Cliente(String nome, String cpf) {
            this.nome = nome;
            this.cpf = cpf;
        }

        public override String ToString() {
            return "Nome: "  + nome + "CPF: " + cpf;
        }
   
    }
}