using semana5.Service;
using semana5.Interface;
  
internal class Program
{
    private static void Main(string[] args)
    {
        //PessoaFisica pessoaFisica = new PessoaFisica(1, "Rua", "123", "Camila", "123", new DateTime(1990,05,1));
        IClienteService clienteService = new ClienteService();
        clienteService.CriarConta();
        clienteService.ExibirClientes();
        
    }
}