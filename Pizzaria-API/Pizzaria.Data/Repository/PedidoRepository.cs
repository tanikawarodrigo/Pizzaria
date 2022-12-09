using AutoMapper;
using Dapper;
using Microsoft.EntityFrameworkCore;
using Pizzaria.Data.IRepository;
using Pizzaria.Domain.DTO;
using Pizzaria.Domain.Model;
using Pizzaria.Infraestructure.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Pizzaria.Data.Repository
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly DapperConnection _connection;
        private readonly IMapper _mapper;
        private const string GetPedidoByIdDapper = @"SELECT * FROM [Pedidos] WHERE Id = @id";
        public PedidoRepository(ApplicationDbContext context, DapperConnection connection, IMapper mapper)
        {
            _context = context;
            _connection = connection;
            _mapper = mapper;
        }

        public async Task<int> CreatePedido(Pedido pedido)
        {
            await _context.Pedidos.AddAsync(pedido);
            var result = await _context.SaveChangesAsync();
            if(result == 0)
            {
                throw new Exception();
            }
            return pedido.Id;
        }

        public void DeletePedido(Pedido pedido)
        {
            _context.Pedidos.Remove(pedido);
        }

        public async Task<List<Pedido>> GetAllPedidos(int skip, int take)
        {
            var pedidos = await _context.Pedidos.Skip(skip).Take(take).ToListAsync();
            return pedidos;
        }

        public async Task<Pedido> GetPedidoById(int id)
        {
            var pedido = await _connection.Connection.QueryFirstOrDefaultAsync<Pedido>(GetPedidoByIdDapper, new { id });
            return pedido;
        }

        public async Task<bool> SaveChanges()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void UpdatePedido(Pedido pedido)
        {
            _context.Pedidos.Update(pedido);
        }
    }
}
