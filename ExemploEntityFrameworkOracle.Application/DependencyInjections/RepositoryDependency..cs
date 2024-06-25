using ExemploEntityFrameworkOracle.Domain.Contracts.Repositories;
using ExemploEntityFrameworkOracle.Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ExemploEntityFrameworkOracle.Application.DependencyInjections
{
	public static class RepositoryDependency
	{
		public static void AddClientDIRepositories(this IServiceCollection services)
		{
			services.AddTransient<IClienteRepository, ClienteRepository>();
		}
	}
}
