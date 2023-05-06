using semana5.Interface;
using semana5.Model;

namespace semana5.Service
{
    public class TransacaoService : ITransacaoService
    {
        private readonly IClienteService _clienteService = new ClienteService()

        public void AdicionaTransacao() {
            Console.Write("Digite o número da conta: ");
            int numeroConta = Int32.Parse(Console.ReadLine());
            Cliente cliente = _clienteService.BuscarClientePorNumeroDeConta(numeroConta);

            Console.Write("Qual o valor da transação: ");
            decimal valor = decimal.Parse(Console.ReadLine());

            Transacao transacao = new Transacao(valor);

            cliente.Extrato.Add(transacao);
        }

        public void ExibirExtrato() {
            Console.Write("Digite o número da conta: ");
            int numeroConta = Int32.Parse(Console.ReadLine());
            Cliente cliente = _clienteService.BuscarClientePorNumeroDeConta(numeroConta);

            foreach(var transacao in cliente.Extrato) {
                Console.WriteLine(transacao.ToString());
                saldo += transacao.Valor;
            }
            Console.WriteLine($"O saldo é de {saldo}");
        }
    }
}