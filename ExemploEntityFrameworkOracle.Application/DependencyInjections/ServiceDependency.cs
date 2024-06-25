using ExemploEntityFrameworkOracle.Application.Services;
using ExemploEntityFrameworkOracle.Domain.Contracts.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ExemploEntityFrameworkOracle.Application.DependencyInjections
{
	public static class ServiceDependency
	{
		public static void AddClientDIServices(this IServiceCollection services)
		{
			services.AddTransient<IClienteService, ClienteService>();
		}
	}
}
