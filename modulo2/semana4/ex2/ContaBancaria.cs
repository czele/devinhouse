using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex2
{
    public class ContaBancaria
    {
        private String NumeroConta { get; set; }
        private decimal _saldo { get; set; }
   

        public ContaBancaria() { }

        public ContaBancaria(String numeroConta, int saldo)
        {
            NumeroConta = numeroConta;
            _saldo = saldo;
        }

        public void deposita(decimal value) {
            _saldo += value;
        }

        public void saca(decimal value) {
            _saldo -= value;
        }

    }
}