using Microsoft.EntityFrameworkCore;
using Pizzaria.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<TipoEntrega> TipoEntregas { get; set; }
        public DbSet<StatusEntrega> StatusEntregas { get; set; }
        public DbSet<StatusPedido> StatusPedidos { get; set; }
        public DbSet<TipoPagamento> TipoPagamentos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PedidoProduto> PedidoProdutos { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> context) : base(context) { }
    }
}
