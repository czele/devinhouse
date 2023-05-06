namespace semana5.Model
{
    public abstract class Cliente
    {
       public int NumeroConta { get; set; }
       public String Endereco { get; set; }
       public String Telefone { get; set; }
       public decimal Saldo { get; set; }
       public List<Transacao> Extrato { get; set; }

        public Cliente() { 
            Extrato = new List<Transacao>();
        }

        public Cliente(int numeroConta, String endereco, String telefone) : this()
        {
            NumeroConta = numeroConta;
            Endereco = endereco;
            Telefone = telefone;
            Saldo = 0;
        }

        public virtual String ResumoCliente() {
           return $"Numero da Conta: {NumeroConta} | End: {Endereco} | Tel: {Telefone} | Saldo: {Saldo.ToString("C2")} |";
        }
       
    }
}