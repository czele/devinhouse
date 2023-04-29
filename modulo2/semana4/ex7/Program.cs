using ex7;

internal partial class Program
{
    private static void Main(string[] args)
    {
        ContaBancaria conta1 = new ContaBancaria("123");
        conta1.Depositar(10000);
        conta1.Sacar(200);
    }
}