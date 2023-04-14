internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Qual a quantidade de números que deseja calcular a média: ");
        int quantidade = Convert.ToInt32(Console.ReadLine());
        int[] numeros = new int[quantidade];
        double soma = 0;

        for(int i=0; i<quantidade; i++) {
            Console.Write("Digite o número: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        foreach (int item in numeros)
        {
            soma += item;
        }
        
        //Console.WriteLine(soma);

        Console.WriteLine(soma/quantidade);

    }
}