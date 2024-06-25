﻿namespace ExemploEntityFrameworkOracle.Domain.Entities
{
	public class Cliente
	{
		public int Id { get; set; }
		public string? Nome { get; set; }
		public DateTime DataCadastro { get; set; }
		public DateTime DataAlteracao { get; set; }
		public bool Status { get; set; }
	}
}
