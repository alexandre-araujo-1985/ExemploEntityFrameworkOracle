using ExemploEntityFrameworkOracle.Domain.Entities;

namespace ExemploEntityFrameworkOracle.Domain.Contracts.Services
{
	public interface IClienteService
	{
		Cliente Pesquisar(int id);
		void Incluir(Cliente cliente);
		void Alterar(int id, Cliente cliente);
		IEnumerable<Cliente> ListarTodos();
		void Excluir(int id);
	}
}
