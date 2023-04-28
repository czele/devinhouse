using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex3
{
    public class ContaBancaria : Cliente
    {
        private String numero { get; set; }
        private Cliente cliente { get; set; }
        private Banco banco;

        public ContaBancaria() { }

        public ContaBancaria(String numero, Cliente cliente, Banco banco)
        {
            this.numero = numero;
            this.cliente = cliente;
            this.banco = banco;
        }
        
        public void depositar(decimal valor) {
            banco.depositar(valor);
        }
        public void sacar(decimal valor) {
            banco.sacar(valor);
        }

        public void exibirDados() {
            Console.WriteLine("Conta" + numero);
            Console.WriteLine(cliente.ToString());
        }

        public override string ToString()
        {
            return "Conta " + numero + " " + cliente.ToString() + " " + banco.ToString();
        }

    }
}