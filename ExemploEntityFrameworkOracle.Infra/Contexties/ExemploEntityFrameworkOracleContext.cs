using Microsoft.EntityFrameworkCore;
using ExemploEntityFrameworkOracle.Domain.Entities;
using ExemploEntityFrameworkOracle.Infra.Configurations;

namespace ExemploEntityFrameworkOracle.Infra.Contexties
{
	public class ExemploEntityFrameworkOracleContext : DbContext
	{
		public DbSet<Cliente> Clientes { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new ClienteConfiguration());
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseOracle("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SID=xe)));User ID=system;Password=Rede@!2018"
				, b => b.UseOracleSQLCompatibility(OracleSQLCompatibility.DatabaseVersion23));
		}
	}
}
