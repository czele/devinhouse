using semana5.Model;
        
internal class Program
{
    private static void Main(string[] args)
    {
        PessoaFisica pessoaFisica = new PessoaFisica(1, "Rua", "123", "Camila", "123", new DateTime(1990,05,1));

        Console.WriteLine(pessoaFisica.EhMaior());
    }
}