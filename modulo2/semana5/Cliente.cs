using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace semana5
{
    public abstract class Cliente
    {
       public String Nome { get; set; }
       public String NumeroConta { get; set; }
       public String Endereco { get; set; }
       public decimal Saldo { get; set; }

        public Cliente() { }

        public Cliente(String nome, String numeroConta, String endereco, decimal saldo)
        {
            Nome = nome;
            NumeroConta = numeroConta;
            Endereco = endereco;
            Saldo = saldo;
        }

        public void ResumoCliente() {
            Console.Write($"Nome: {Nome} - Numero da Conta: {NumeroConta} - Endereço: {Endereco} - Saldo: {Saldo}");
        }
       
    }
}