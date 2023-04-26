using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex2
{
    public class ContaBancaria
    {
        private String NumeroConta { get; set; }
        private int Saldo { get; set; }
   

        public ContaBancaria(String numeroConta, int saldo)
        {
            NumeroConta = numeroConta;
            Saldo = saldo;
        }

        public int getSaldo() {
            return Saldo;
        }

        public void setSaldo() {

        }
    }
}