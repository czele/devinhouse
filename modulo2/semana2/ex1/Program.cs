internal class Program
{
    private static void Main(string[] args)
    {

        Console.Write("Digite o primeiro número: ");  
        int numero1 = Convert.ToInt16(Console.ReadLine());
        
        Console.Write("Digite o primeiro número: ");  
        int numero2 = Convert.ToInt16(Console.ReadLine());

        int soma = numero1 + numero2;

       Console.WriteLine($"A soma dos números é {soma}");
       
    }
}