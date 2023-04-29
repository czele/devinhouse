using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex4
{
    public class ContaBancaria
    {
        public decimal Saldo { get; private set; }

        public ContaBancaria() { }

        public ContaBancaria(decimal saldo)
        {
            this.Saldo = saldo;
        }

        public decimal Depositar(decimal valor) {
            return Saldo += valor;
        }

        public bool Sacar(decimal valor) {
            if(valor > Saldo) {
                Console.WriteLine("Pobre. Saldo insuficiente");
                return false;
            }
            else {
                Saldo -= valor;
                return true;
            }
        }
        
    }
}