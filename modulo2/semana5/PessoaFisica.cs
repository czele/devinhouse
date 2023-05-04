using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace semana5.obj
{
    public class PessoaFisica : Cliente
    {
        public int AnoNascimento { get; set; }
        public String Cpf { get; set; }

        public PessoaFisica() {}
       
        public PessoaFisica(int anoNascimento, String cpf)
        {
            anoNascimento = AnoNascimento;
            cpf = Cpf;
        }

        public bool EhMaior(int anoNascimento) {
            if (anoNascimento - 2023 >= 18) {
                return true;
            } return false;
        }
    }
}