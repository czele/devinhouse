using ex9;

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite o primeiro número: ");
        float NumA = float.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        float NumB = float.Parse(Console.ReadLine());
        Console.Write("Digite o raio da circunferência: ");
        float Raio = float.Parse(Console.ReadLine());

        Calculadora.Soma(NumA, NumB);
        Calculadora.Subtracao(NumA, NumB);
        Calculadora.Multiplicacao(NumA, NumB);
        Calculadora.Divisao(NumA, NumB);
        Calculadora.AreaCirculo(Raio);
     
        
    }
}