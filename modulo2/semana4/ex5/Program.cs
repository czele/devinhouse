using ex5;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa pessoa = new ();
        pessoa.DefinirNome("Camila");
        pessoa.DefinirIdade(20);
        pessoa.DefinirIdade(-5);
    }
}