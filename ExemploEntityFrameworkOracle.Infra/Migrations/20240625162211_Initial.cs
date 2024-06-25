using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExemploEntityFrameworkOracle.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    nome = table.Column<string>(type: "varchar(100)", nullable: true),
                    data_cadastro = table.Column<DateTime>(type: "datetime", nullable: false),
                    data_alteracao = table.Column<DateTime>(type: "datetime", nullable: false),
                    status = table.Column<bool>(type: "BOOLEAN", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_clientes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_clientes");
        }
    }
}
