using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex7
{
    public class ContaBancaria
    {
        public String NumeroConta { get; set; }
        public const decimal SaldoMaximo = 1000;

        public ContaBancaria() { }

        public ContaBancaria(String numeroConta)
        {
            this.NumeroConta = NumeroConta;    
        }

        public void Depositar(decimal valor) {
            if(valor > 0 && valor < SaldoMaximo) {
                System.Console.WriteLine("Depósito permitido");
            } else {
                System.Console.WriteLine("Depósito negado");
            }
        }

        public void Sacar(decimal valor) {
            if(valor < SaldoMaximo) {
                System.Console.WriteLine("Saque permitido");
            } else {
                System.Console.WriteLine("Saque negado");
            }

        }
    }
}