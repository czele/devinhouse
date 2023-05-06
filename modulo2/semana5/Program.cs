using semana5.Service;
using semana5.Interface;
  
internal class Program
{
    private static void Main(string[] args)
    {
        String opcao;

        do {
            Console.WriteLine("\n\nBem Vindo ao banco Fullstack, Escolha uma opção para continuar: ");
            Console.WriteLine("1 - Abrir Conta");
            Console.WriteLine("2 - Consultar Conta");
            Console.WriteLine("3 - Listar Todas as contas");
            Console.WriteLine("4 - Sair\n");
            opcao = Console.ReadLine();
            SelecaoMenu(opcao);
        } while (opcao != "4");       
    

        void SelecaoMenu(String opcao) {
            IClienteService clienteService = new ClienteService();
            switch(opcao) {
            case "1":
                clienteService.CriarConta();
                break;
            case "2":
                Console.Write("Digite o número da conta: ");
                int numeroConta = Int32.Parse(Console.ReadLine());
                var cliente = clienteService.BuscarClientePorNumeroDeConta(numeroConta);
                if(cliente == null) 
                    Console.WriteLine("Conta não foi indentificada");
                else
                    Console.WriteLine(cliente.ResumoCliente());
                break;
            case "3":
                clienteService.ExibirClientes();
                break;
            case "4":
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
            }    

        }
    }    
    
}