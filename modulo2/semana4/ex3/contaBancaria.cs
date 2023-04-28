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

        public ContaBancaria() { }

        public ContaBancaria(String numero, Cliente cliente)
        {
            this.numero = numero;
            this.cliente= cliente;;
        }

        public void contaBancaria() {
            Console.WriteLine($"Número: {numero}, nome: {nome}, cpf: {cpf}");
        }
    }
}