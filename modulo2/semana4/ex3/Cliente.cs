using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex3
{
    public class Cliente
    {
        private String nome;
        private String cpf;

        public Cliente() { }

        public Cliente(String nome, String cpf) {
            this.nome = nome;
            this.cpf = cpf;
        }
            
    }
}