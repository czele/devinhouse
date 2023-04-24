using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Prop + tab cria o get e set
namespace excarros
{
    public class Proprietario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }

        public Proprietario(string nome, string cpf, string telefone)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
        }

        public string Imprimir() {
            return $"Nome: {Nome}  CPF: {Cpf}  Telefone: {Telefone}" ;           
        }
        
    }
}