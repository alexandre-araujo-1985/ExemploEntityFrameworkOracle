using ExemploEntityFrameworkOracle.Domain.Entities;

namespace ExemploEntityFrameworkOracle.Domain.Contracts.Repositories
{
	public interface IClienteRepository : IRepositoryBase<Cliente>
	{
		void AlterarParcial(Cliente cliente);
		void Inativar(int id);
	}
}
