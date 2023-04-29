using ex4;

internal partial class Program
{
    private static void Main(string[] args)
    {
        ContaBancaria conta = new ContaBancaria(500);

        conta.Depositar(100);
        Console.WriteLine(conta.Saldo);

        conta.Sacar(50);
        Console.WriteLine(conta.Saldo);
    }
}