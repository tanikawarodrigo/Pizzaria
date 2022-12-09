using Pizzaria.Domain.DTO;
using Pizzaria.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Service.IService
{
    public interface IProdutoService
    {
        Task<ProdutoDTO> CreateProduto(ProdutoDTO produtoDTO);
        Task<List<Produto>> GetAllProdutos();
        Task<List<Produto>> GetAllBebidas();

        Task<Produto> GetProdutoById(int id);
        Task<bool> DeleteProdutoById(int id);
        Task<bool> UpdateProduto(ProdutoDTO produtoDTO);
    }
}
