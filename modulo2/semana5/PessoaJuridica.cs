using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace semana5.obj
{
    public class PessoaJuridica : Cliente
    {
        public long Cnpj { get; set; }
        public String RazaoSocial { get; set; }

        public PessoaJuridica() { }

        public PessoaJuridica(long cnpj, String razaoSocial)
        {
            cnpj = Cnpj;
            razaoSocial = RazaoSocial;
        }

        
    }
}