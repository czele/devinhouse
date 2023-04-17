internal class Program
{
    private static void Main(string[] args)
    {
<<<<<<< HEAD
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
=======
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
>>>>>>> 0279a0a6a1d87c7403ed824ee09f7419d79702b7

    }
}