namespace ExemploEntityFrameworkOracle.Domain.Contracts.Repositories
{
	public interface IRepositoryBase<T> where T : class
	{
		T Pesquisar(int id);
		void Incluir(T obj);
		void Alterar(T obj);
		IEnumerable<T> ListarTodos();
		void Excluir(int id);
	}
}
