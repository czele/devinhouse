using ex1;

internal class Program : Pessoa
{
    public static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa("Camila", 30);


        void saudacao(Pessoa pessoa) {
        Console.WriteLine($"Olá, meu nome é {pessoa.getNome()} e eu tenho {pessoa.getIdade()} anos.");
        }

        saudacao(pessoa);
    }
}