using Pizzaria.Domain.DTO;
using Pizzaria.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Data.IRepository
{
    public interface IPedidoRepository
    {
        Task<bool> SaveChanges();
        Task<int> CreatePedido(Pedido pedido);
        void DeletePedido(Pedido pedido);
        void UpdatePedido(Pedido pedido);
        Task<List<Pedido>> GetAllPedidos(int skip, int take);
        Task<Pedido> GetPedidoById(int id);

    }
}
