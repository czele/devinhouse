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

        /* Para printar um array tem que sempre ser dentro de um foreach
        foreach (var item in numeros) {
            Console.Write(item);
        }*/
        
        Console.WriteLine(numeros.Max());

    }
}