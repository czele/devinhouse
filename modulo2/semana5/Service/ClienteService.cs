using semana5.Model;

namespace semana5.Service
{
    public class ClienteService
    {
        private static List<Cliente> _clientes = new List<Cliente>();

        private Cliente PreencheCliente(Cliente cliente) {
            Console.Write("Número da conta: ");
            cliente.NumeroConta = Int32.Parse(Console.ReadLine());
            Console.Write("Endereço: ");
            cliente.Endereco = Console.ReadLine();
            Console.Write("Telefone: ");
            cliente.Telefone = Console.ReadLine();
            return cliente; 
        }

        public void CriarConta() {
            Console.Write("Opção: (1 - Pessoa Física | 2 - Pessoa Jurídica)");
            int opcao = Int32.Parse(Console.ReadLine());

            if (opcao == 1) {
                CriarContaPessoaFisica();

            } else if (opcao == 2) {
                CriarContaPessoaJuridica();
                   
            } else {
                Console.WriteLine("Opção incorreta");
            }
        }
    
        public void ExibirClientes() {
            foreach (Cliente cliente in _clientes) {
                Console.WriteLine(cliente.ResumoCliente());
            }
        }

        public Cliente BuscarClientePorNumeroDeConta(int numeroConta) {
            return _clientes.Find(x => x.NumeroConta == numeroConta);
        }

        private void CriarContaPessoaFisica() {
            PessoaFisica clientePF = new PessoaFisica();

            Console.Write("Data de Nascimento: ");
            //Usar o Tryparse
            clientePF.DataNascimento = DateTime.Parse(Console.ReadLine());

            if (!clientePF.EhMaior()) {
                Console.WriteLine("Cliente menor de idade.");
                return;
            }

            PreencheCliente(clientePF);

            Console.Write("CPF: ");
            clientePF.Cpf = Console.ReadLine();
            Console.Write("Nome: ");
            clientePF.Nome = Console.ReadLine();

            _clientes.Add(clientePF);
        }

        private void CriarContaPessoaJuridica() {
            PessoaJuridica clientePJ = new PessoaJuridica();
            PreencheCliente(clientePJ);
            Console.Write("CNPJ: ");
            clientePJ.Cnpj = long.Parse(Console.ReadLine());
            Console.Write("Razão Social: ");
            clientePJ.RazaoSocial = Console.ReadLine();

            _clientes.Add(clientePJ);
        }

    }
}