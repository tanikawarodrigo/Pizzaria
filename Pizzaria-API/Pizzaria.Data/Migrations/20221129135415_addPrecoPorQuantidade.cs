using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pizzaria.Data.Migrations
{
    /// <inheritdoc />
    public partial class addPrecoPorQuantidade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AtualizadoPor",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CriadoPor",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DataAtualizacao",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DataCriacao",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "AtualizadoPor",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "CriadoPor",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "DataAtualizacao",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "DataCriacao",
                table: "Pedidos");

            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "Produtos",
                newName: "PrecoUnitario");

            migrationBuilder.RenameColumn(
                name: "PrecoFinal",
                table: "Pedidos",
                newName: "PrecoTotal");

            migrationBuilder.AddColumn<float>(
                name: "PrecoPorQuantidade",
                table: "PedidoProdutos",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrecoPorQuantidade",
                table: "PedidoProdutos");

            migrationBuilder.RenameColumn(
                name: "PrecoUnitario",
                table: "Produtos",
                newName: "Preco");

            migrationBuilder.RenameColumn(
                name: "PrecoTotal",
                table: "Pedidos",
                newName: "PrecoFinal");

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "AtualizadoPor",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CriadoPor",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAtualizacao",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCriacao",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Pedidos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "AtualizadoPor",
                table: "Pedidos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CriadoPor",
                table: "Pedidos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAtualizacao",
                table: "Pedidos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCriacao",
                table: "Pedidos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
