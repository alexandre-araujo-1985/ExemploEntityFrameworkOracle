using Microsoft.EntityFrameworkCore;
using ExemploEntityFrameworkOracle.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExemploEntityFrameworkOracle.Infra.Configurations
{
	public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
	{
		public void Configure(EntityTypeBuilder<Cliente> builder)
		{
			builder.ToTable("tb_clientes");

			builder.HasKey(c => c.Id);

			builder.Property(c => c.Nome).HasColumnName("nome").HasColumnType("varchar(100)");
			builder.Property(c => c.DataCadastro).HasColumnName("data_cadastro").HasColumnType("datetime");
			builder.Property(c => c.DataAlteracao).HasColumnName("data_alteracao").HasColumnType("datetime");
			builder.Property(c => c.Status).HasColumnName("status");
		}
	}
}
