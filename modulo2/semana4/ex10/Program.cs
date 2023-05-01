using ex10;

internal partial class Program
{
    private static void Main(string[] args)
    {

        ContaBancaria contaBancaria = new ContaBancaria(0);
        contaBancaria.Deposito(30);
        contaBancaria.Saque(10);
        contaBancaria.Deposito(20);
        contaBancaria.Saque(80);
        contaBancaria.VerificarSaldo();
        contaBancaria.VerificarTransacoes();
    }
}