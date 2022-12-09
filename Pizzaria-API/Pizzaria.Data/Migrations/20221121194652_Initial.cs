using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pizzaria.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProdutoCategoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoCategoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusEntregas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusEntregas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusPedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusPedidos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoEntregas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preço = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoEntregas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoPagamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPagamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endereço = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CriadoPor = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AtualizadoPor = table.Column<int>(type: "int", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProduto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preço = table.Column<float>(type: "real", nullable: false),
                    ProdutoCategoriaId = table.Column<int>(type: "int", nullable: false),
                    CriadoPor = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AtualizadoPor = table.Column<int>(type: "int", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_ProdutoCategoria_ProdutoCategoriaId",
                        column: x => x.ProdutoCategoriaId,
                        principalTable: "ProdutoCategoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endereço = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrecoFinal = table.Column<float>(type: "real", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    TipoPagamentoId = table.Column<int>(type: "int", nullable: false),
                    StatusPedidoId = table.Column<int>(type: "int", nullable: false),
                    TipoEntregaId = table.Column<int>(type: "int", nullable: false),
                    StatusEntregaId = table.Column<int>(type: "int", nullable: false),
                    CriadoPor = table.Column<int>(type: "int", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AtualizadoPor = table.Column<int>(type: "int", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedidos_StatusPedidos_StatusPedidoId",
                        column: x => x.StatusPedidoId,
                        principalTable: "StatusPedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedidos_TipoEntregas_TipoEntregaId",
                        column: x => x.TipoEntregaId,
                        principalTable: "TipoEntregas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedidos_TipoPagamentos_TipoPagamentoId",
                        column: x => x.TipoPagamentoId,
                        principalTable: "TipoPagamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedidos_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PedidoProdutos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PedidoId = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    QuantidadeProduto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoProdutos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PedidoProdutos_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidoProdutos_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PedidoProdutos_PedidoId",
                table: "PedidoProdutos",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoProdutos_ProdutoId",
                table: "PedidoProdutos",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_StatusPedidoId",
                table: "Pedidos",
                column: "StatusPedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_TipoEntregaId",
                table: "Pedidos",
                column: "TipoEntregaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_TipoPagamentoId",
                table: "Pedidos",
                column: "TipoPagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_UserId",
                table: "Pedidos",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_ProdutoCategoriaId",
                table: "Produtos",
                column: "ProdutoCategoriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PedidoProdutos");

            migrationBuilder.DropTable(
                name: "StatusEntregas");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "StatusPedidos");

            migrationBuilder.DropTable(
                name: "TipoEntregas");

            migrationBuilder.DropTable(
                name: "TipoPagamentos");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ProdutoCategoria");
        }
    }
}
