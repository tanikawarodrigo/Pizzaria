using Pizzaria.Domain.DTO;
using Pizzaria.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Data.IRepository
{
    public interface IProdutoRepository
    {
        Task<bool> SaveChanges();
        void CreateProduto(ProdutoDTO produtoDTO);
        Task<Produto> GetProdutoById(int id);
        Task<List<Produto>> GetAllProduto();
        Task<List<Produto>> GetAllBebidas();

        void DeleteProdutoById(Produto produto);
        void UpdateProduto(Produto produto);
        Task<Produto> GetProdutoByName(string nome);
    }
}
