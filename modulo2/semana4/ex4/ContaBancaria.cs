using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex4
{
    public class ContaBancaria
    {
        private decimal saldo;

        public ContaBancaria() { }

        public ContaBancaria(decimal saldo)
        {
            this.saldo = saldo;
        }

        public decimal Saldo {
            get { return saldo; }
            set { saldo = value >=0 ? value : 0; }
        }

        public decimal Depositar(decimal valor) {
            return saldo += valor;
        }

        public bool Sacar(decimal valor) {
            if(valor >= saldo && valor >= 0) {
                saldo -= valor;
                return true;
            }
            else {
                Console.WriteLine("Pobre. Saldo insuficiente");
                return false;
            }
        }
        
    }
}