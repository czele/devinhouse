using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex3
{
    public class contaBancaria
    {
        private String numero;
        private Cliente cliente;

        public contaBancaria() { }

        public contaBancaria(String numero, Cliente cliente)
        {
            this.numero = numero;
            this.cliente= cliente;;
        }
    }
}