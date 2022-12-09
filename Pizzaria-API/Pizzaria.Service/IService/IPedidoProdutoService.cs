using Pizzaria.Domain.DTO;
using Pizzaria.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Service.IService
{
    public interface IPedidoProdutoService
    {
        Task<bool> CreatePedidoProduto(PedidoProdutoDTO pedidoProdutoDto);
        //Task<List<Produto>> GetAllProdutos(int skip, int take);
        //Task<Produto> GetProdutoById(int id);
        //Task<bool> DeleteProdutoById(int id);
    }
}
