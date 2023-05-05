using semana5.Model;

namespace semana5.Service
{
    public class ClienteService
    {
        public static List<ClienteService> clientes = new List<ClienteService>();

        public void CriarConta(int opcao) {
            if (opcao == 1) {
                PessoaFisica pessoaFisica = new PessoaFisica();
                Console.Write("Número da conta: ");
                pessoaFisica.NumeroConta = Int32.Parse(Console.ReadLine());
                Console.Write("Endereço: ");
                pessoaFisica.Endereco = Console.ReadLine();
                Console.Write("Telefone: ");
                pessoaFisica.Telefone = Console.ReadLine();
                Console.Write("Nome: ");
                pessoaFisica.Nome = Console.ReadLine();
                Console.Write("Data de Nascimento: ");
                pessoaFisica.DataNascimento = DateTime.Parse(Console.ReadLine());
                Console.Write("CPF: ");
                pessoaFisica.Cpf = Console.ReadLine();
            } else {
                PessoaJuridica pessoaJuridica = new PessoaJuridica();
                Console.Write("Número da conta: ");
                pessoaJuridica.NumeroConta = Int32.Parse(Console.ReadLine());
                Console.Write("Endereço: ");
                pessoaJuridica.Endereco = Console.ReadLine();
                Console.Write("Telefone: ");
                pessoaJuridica.Telefone = Console.ReadLine();
                Console.Write("CNPJ: ");
                pessoaJuridica.Cnpj = long.Parse(Console.ReadLine());
                Console.Write("Razão Social: ");
                pessoaJuridica.RazaoSocial = Console.ReadLine();
                
   
            }
        }
    }
}