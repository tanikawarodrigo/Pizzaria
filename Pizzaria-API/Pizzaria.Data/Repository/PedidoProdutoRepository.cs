using Pizzaria.Data.IRepository;
using Pizzaria.Domain.DTO;
using Pizzaria.Domain.Model;
using Pizzaria.Infraestructure.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Data.Repository
{
    public class PedidoProdutoRepository : IPedidoProdutoRepository
    {
        private readonly DapperConnection _connection;
        private readonly ApplicationDbContext _context;
        public PedidoProdutoRepository(DapperConnection connection, ApplicationDbContext context)
        {
            _connection = connection;
            _context = context;
        }

        public async void CreatePedidoProduto(PedidoProduto pedidoProduto)
        {
            await _context.PedidoProdutos.AddAsync(pedidoProduto);
        }

        public void DeletePedidoProduto(PedidoProduto pedidoProduto)
        {
            _context.PedidoProdutos.Remove(pedidoProduto);
        }

        public Task<List<PedidoProduto>> GetAllPedidoProdutos(int skip, int take)
        {
            throw new NotImplementedException();
        }

        public Task<PedidoProduto> GetPedidoProdutoById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveChanges()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void UpdatePedidoProduto(PedidoProduto pedidoProdutoDto)
        {
            _context.PedidoProdutos.Update(pedidoProdutoDto);
        }
    }
}
