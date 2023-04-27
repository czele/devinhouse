using ex2;

internal class Program
{
    private static void Main(string[] args)
    {
        ContaBancaria conta1 = new ContaBancaria("123", 200);

        conta1.deposita(200);
        conta1.saca(500);
        conta1.getSaldo();
    }
}