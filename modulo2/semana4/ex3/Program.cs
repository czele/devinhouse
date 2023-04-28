using ex3;

internal class Program
{
    private static void Main(string[] args)
    {
        Banco banco = new Banco(100);
        Cliente cliente = new Cliente("Camila", "123");
        ContaBancaria contaBancaria = new ContaBancaria("123", cliente, banco);

        Console.WriteLine("Dados da conta:");
        contaBancaria.exibirDados();
        Console.WriteLine("");
        Console.WriteLine("Depósito de 1000");
        contaBancaria.depositar(1000);
        Console.WriteLine(contaBancaria.ToString());
        Console.WriteLine("Saque de 500");
        contaBancaria.sacar(500);
        Console.WriteLine(contaBancaria.ToString());

    }
}