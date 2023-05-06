using semana5.Model;

namespace semana5.Interface
{
    public interface IClienteService
    {
        public void CriarConta() ;

        public Cliente BuscarClientePorNumeroDeConta(int numeroConta);

        void ExibirClientes();
    }
}