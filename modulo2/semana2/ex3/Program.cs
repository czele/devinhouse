internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite seu nome: ");  
        string nome = Console.ReadLine();
        var upper = char.ToUpper(nome[0]) + nome.Substring(1);

        Console.Write("Digite sua idade: ");  
        int idade = Convert.ToInt16(Console.ReadLine());

        while(idade<0) {
            Console.Write("Idade inválida. Por favor, digite sua idade novamente: ");  
            idade = Convert.ToInt16(Console.ReadLine());
        }

        if (idade>=0 & idade<18) {
            Console.WriteLine($"{upper}, você é menor de idade.");
        } else if(idade>=18 & idade<60) {
             Console.WriteLine($"{upper}, você é maior de idade.");
        } else if(idade>=60) {
             Console.WriteLine($"{upper}, você é idoso.");
        } else {
            Console.WriteLine("Idade inválida");
        }
    }
}
