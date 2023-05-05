namespace semana5.Model
{
    public class PessoaJuridica : Cliente
    {
        public long Cnpj { get; set; }
        public String RazaoSocial { get; set; }

        public PessoaJuridica() { }

        public PessoaJuridica(int numeroConta, String endereco, String telefone, long cnpj, String razaoSocial)
                            : base (numeroConta, endereco, telefone)
        {
            cnpj = Cnpj;
            razaoSocial = RazaoSocial;
        }

    }
}