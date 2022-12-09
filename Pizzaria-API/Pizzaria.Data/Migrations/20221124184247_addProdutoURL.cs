using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pizzaria.Data.Migrations
{
    /// <inheritdoc />
    public partial class addProdutoURL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "AtualizadoPor",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "CriadoPor",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "DataAtualizacao",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "DataCriacao",
                table: "Produtos");

            migrationBuilder.RenameColumn(
                name: "Preço",
                table: "Produtos",
                newName: "Preco");

            migrationBuilder.AddColumn<string>(
                name: "ProdutoURL",
                table: "Produtos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProdutoURL",
                table: "Produtos");

            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "Produtos",
                newName: "Preço");

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Produtos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "AtualizadoPor",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CriadoPor",
                table: "Produtos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAtualizacao",
                table: "Produtos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCriacao",
                table: "Produtos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
