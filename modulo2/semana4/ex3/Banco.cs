using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex3
{
    public class Banco
    {
        private decimal _saldo;
    }
     
    public Banco() { }

    public Banco(decimal saldo)
    {
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
}