using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex10
{
    public class ContaBancaria
    {
        private decimal saldo;
        private String transacoes;

        public ContaBancaria() { }

        public ContaBancaria(decimal saldo)
        {
            this.saldo = saldo;
        }

        public decimal Saldo {
            get { return saldo; }
            set { saldo = value; }
        }

        public void Deposito(decimal valor) {
            saldo += valor;
            transacoes += $"\n----------\nDepósito de R$:{valor}\nSaldo atual de R$:{saldo}\n----------\n"; 
        }

        public bool Saque(decimal valor) {
            if(valor < saldo) {
                saldo -= valor;
                transacoes += $"\n----------\nSaque de R$:{valor}\nSaldo atual de R$:{saldo}\n----------\n";
                return true; 
            } else {
                transacoes += $"\n----------\nTentativa de saque de R$:{valor}\nSaldo atual de R$:{saldo}\n----------\n";
                return false;
            }
        }

        public void VerificarSaldo() {
            System.Console.WriteLine($"Saldo: {saldo}");
        }

        public void VerificarTransacoes() {
           System.Console.WriteLine(transacoes);
        }

    }
}