internal class Program
{
        public float Soma(float num1, float num2) {
            float resultado;
            resultado = num1 + num2;
            return resultado; 
        }

        public float Subtracao(float num1, float num2) {
            float resultado;
            resultado = num1 - num2;
            return resultado; 
        }

        public float Multiplicacao(float num1, float num2) {
            float resultado;
            resultado = num1 * num2;
            return resultado; 
        }

        public float Divisao(float num1, float num2) {
            float resultado;
            resultado = num1 / num2;
            return resultado; 
        }
    private static void Main(string[] args)
    {
        float num1, num2, resultado;
        string operacao; 

        do
        {
        Console.WriteLine("Que operação deseja fazer (+ soma |- subtração | * multiplicação | / divisão | ? sair): ");
        operacao = Console.ReadLine();
            if(operacao != "?") {
            Console.WriteLine("Digite o primeiro número: ");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = float.Parse(Console.ReadLine());
                switch (operacao) {
                    case "+":
                    //Soma(num1,num2);
                    resultado = num1 + num2;
                    Console.WriteLine($"Resultado: {resultado}");
                    break;
                    case "-":
                    resultado = num1 - num2;
                    Console.WriteLine($"Resultado: {resultado}");
                    //Subtracao(num1,num2);
                    break;
                    case "*":
                    resultado = num1 * num2;
                    Console.WriteLine($"Resultado: {resultado}");
                    //Multiplicacao(num1,num2);
                    break;
                    case "/":
                    if(num2 == 0) {
                         Console.WriteLine("Número inválido, favor digitar o número novamente: ");
                        num2 = float.Parse(Console.ReadLine());
                    } else {
                    resultado = num1 / num2;
                    Console.WriteLine($"Resultado: {resultado}");}
                    //Divisao(num1,num2);
                    break;
                }
                } else {Console.WriteLine("Obrigado por utilizar a calculadora");}
        } while (operacao != "?");
        
    }

}