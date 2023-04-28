using ex3;

internal class Program
{
    private static void Main(string[] args)
    {
        Banco banco = new Banco(100);
        Cliente cliente = new Cliente("Camila", "123");
        ContaBancaria contaBancaria = new ContaBancaria("123", cliente);

    }
}