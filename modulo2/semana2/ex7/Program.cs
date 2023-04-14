internal class Program
{
    private static void Main(string[] args)
    {   
        int numero;

        do
        {
        Console.Write("Digite um número inteiro: ");
        numero = Convert.ToInt32(Console.ReadLine());
            if (numero <= 0) {
                Console.Write("Número inválido, por favor, digite um número válido: ");
            }
        } while (numero <= 0); 

        for(int i=0; i<=numero; i+=2) {
            Console.Write($"{i} ");
        }  
        
    }
}