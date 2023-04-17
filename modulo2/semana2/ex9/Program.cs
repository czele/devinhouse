internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Qual a quantidade de números que você deseja fazer a média: ");  
        int quantidade = Convert.ToInt32(Console.ReadLine());
        int soma = 0;
        double media;

        int[] numeros = new int[quantidade];

        for(int i=0; i<numeros.Length; i++) {
            Console.Write("Digite o número desejado: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        foreach (var item in numeros)
        {
            soma += item;
        }

        Console.Write(media = soma / quantidade);

    }
}