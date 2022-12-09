using Pizzaria.Domain.DTO;
using Pizzaria.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Data.IRepository
{
    public interface IPedidoProdutoRepository
    {
        Task<bool> SaveChanges();
        void CreatePedidoProduto(PedidoProduto pedidoProduto);
        void DeletePedidoProduto(PedidoProduto pedidoProduto);
        void UpdatePedidoProduto(PedidoProduto pedidoProduto);
        Task<List<PedidoProduto>> GetAllPedidoProdutos(int skip, int take);
        Task<PedidoProduto> GetPedidoProdutoById(int id);
    }
}
