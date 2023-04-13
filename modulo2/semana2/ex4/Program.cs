internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite a marca do carro: ");
        string marca = Console.ReadLine();
        var upper = char.ToUpper(marca[0]) + marca.Substring(1);

        Console.Write("Digite o modelo do carro: ");  
        string modelo = Console.ReadLine();
    
        Console.Write("Digite os quilômetros rodados: ");  
        float km = float.Parse(Console.ReadLine());

        if(km>10000) {
        Console.WriteLine($"O carro {modelo}, da marca {upper} necessita de uma revisão.");
        } else {
        Console.WriteLine($"O carro {modelo}, da marca {upper} e está com {km} kms rodados");
        }

    }
}