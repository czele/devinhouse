internal class Program
{
    private static void Main(string[] args)
    {
        int[] numeros = new int[4];

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("Digite um número inteiro: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());  
        
        }
        
        Console.WriteLine(numeros.Max());

    }
}