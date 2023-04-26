using ex2;

internal class Program : ContaBancaria
{
    private static void Main(string[] args)
    {
        ContaBancaria contaBancaria = new ContaBancaria("123", 100);
        int saldodaConta = contaBancaria.getSaldo();
        Console.WriteLine(saldodaConta);
    }
}