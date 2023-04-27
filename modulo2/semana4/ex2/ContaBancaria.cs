using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex2
{
    public class ContaBancaria
    {
        private String numeroConta { get; set; }
        private decimal _saldo { get; set; }
   

        public ContaBancaria() { }

        public ContaBancaria(String numeroConta, int saldo)
        {
            this.numeroConta = numeroConta;
            _saldo = saldo;
        }

        public void deposita(decimal value) {
            _saldo += value;
            Console.WriteLine(_saldo);
        }

        public void saca(decimal value) {
            if(value > _saldo) {
                Console.WriteLine("Saldo insuficiente");
                return;
            }
            _saldo -= value;
            Console.WriteLine(_saldo);
        }

        public decimal getSaldo() {
            return _saldo;
        }

    }
}