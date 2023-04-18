internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Digite o primeiro número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o terceiro número: ");
        double num3 = Convert.ToDouble(Console.ReadLine());


        Calcular(num1, num2);
        Calcular(num1, num2, num3);
    }


    static int Calcular(int num1, int num2) {
        int resultado = num1 + num2;
        Console.WriteLine(resultado);
        return resultado;
    }
    static double Calcular(double num1, double num2) {
        double resultado = num1 + num2;
        Console.WriteLine(resultado);
        return resultado;
    }

        static double Calcular(double num1, double num2, double num3) {
        double resultado = num1 + num2 + num3;
        Console.WriteLine(resultado);
        return resultado;
    }

}