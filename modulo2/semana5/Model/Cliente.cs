namespace semana5.Model
{
    public abstract class Cliente
    {
       public int NumeroConta { get; set; }
       public String Endereco { get; set; }
       public String Telefone { get; set; }
       public decimal Saldo { get; set; }

        public Cliente() { }

        public Cliente(int numeroConta, String endereco, String telefone)
        {
            NumeroConta = numeroConta;
            Endereco = endereco;
            Telefone = telefone;
            Saldo = 0;
        }

        public String ResumoCliente() {
           return $"Numero da Conta: {NumeroConta} | End: {Endereco} | Tel: {Telefone} | Saldo: {Saldo}";
        }
       
    }
}