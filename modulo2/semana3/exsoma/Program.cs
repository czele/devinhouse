internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Digite o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Calcular(num1, num2);
    }

    static double Calcular(double num1, double num2) {
        double resultado = num1 + num2;
        Console.WriteLine(resultado);
        return resultado;
    }

}