using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex3
{
    public class Banco
    {
        private decimal _saldo { get; set; }
    
        public Banco() { }

        public Banco(decimal saldo)
        {
            _saldo = saldo;
        }

        public void depositar(decimal value) {
                _saldo += value;
                Console.WriteLine(_saldo);
            }

        public void sacar(decimal value) {
            if(value > _saldo) {
                Console.WriteLine("Saldo insuficiente");
                return;
            }
            _saldo -= value;
            Console.WriteLine(_saldo);
        }

        //O override só é usado em String, para sobreescrever
        public override String ToString() {
            return "Saldo " + _saldo;
        }
    }
}