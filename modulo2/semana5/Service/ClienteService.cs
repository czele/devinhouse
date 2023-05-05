using semana5.Model;

namespace semana5.Service
{
    public class ClienteService
    {
        public static List<Cliente> clientes = new List<Cliente>();
     
        public void CriarConta() {
            Console.Write("Opção: ");
            int opcao = Int32.Parse(Console.ReadLine());

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
                if (pessoaFisica.EhMaior() == false) {
                    Console.WriteLine("Uma pessoa menor de idade não pode ter uma conta");
                } else {
                    Console.Write("CPF: ");
                    pessoaFisica.Cpf = Console.ReadLine();
                    clientes.Add(pessoaFisica);
                }

            } else if (opcao == 2) {
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
                clientes.Add(pessoaJuridica);
                
            } else {
                Console.WriteLine("Opção incorreta");
            }
        }

        public void ExibirClientes() {
                foreach (Cliente cliente in clientes) {
                    Console.WriteLine(cliente.ResumoCliente());
                }
            }

    }
}