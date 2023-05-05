namespace semana5.Model
{
    public class PessoaFisica : Cliente
    {
        public String Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public String Cpf { get; set; }

        public PessoaFisica() {}
       
        public PessoaFisica(int numeroConta, String endereco, String telefone, String nome, String cpf, DateTime dataNascimento) 
                            : base (numeroConta, endereco, telefone)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Cpf = cpf;
        }

        public bool EhMaior() {
            int idade = DateTime.Now.Year - DataNascimento.Year;
            if (!(DateTime.Now.Month >= DataNascimento.Month && DateTime.Now.Day >= DataNascimento.Day)){
                idade --;
            }
            return idade >= 18;
        }
    }
}