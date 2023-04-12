
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite o primeiro número: ");  
        int numero = Convert.ToInt16(Console.ReadLine());

        if(numero%2==0) {
            Console.WriteLine("Esse número é par");
        } else {
           Console.WriteLine("Esse número é ímpar"); 
        }
    }
}