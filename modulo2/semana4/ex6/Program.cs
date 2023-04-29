using ex6;

internal partial class Program
{
    private static void Main(string[] args)
    {
        Retangulo retangulo1 = new Retangulo(10, 20);
        retangulo1.Altura = 10;
        retangulo1.Largura = 20;
        retangulo1.CalcularArea();

        Retangulo retangulo2 = new Retangulo(-10, 20);
        retangulo2.CalcularArea();
        
    }
}